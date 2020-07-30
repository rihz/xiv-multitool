using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Controllers.Tasks.Models;
using XIVChecklist.Data.Context;
using XIVChecklist.Entities.Common;
using XIVChecklist.Entities.Tasks;
using XIVChecklist.Entities.Tasks.Collections;
using XIVChecklist.Entities.Tasks.GameLogs;
using XIVChecklist.Entities.Tasks.Logs;
using XIVChecklist.Entities.Tasks.MSQ;
using XIVChecklist.Entities.Tasks.PvE;
using XIVChecklist.Entities.Tasks.SQ;
using XIVChecklist.Entities.Tasks.Triple_Triad;

namespace XIVChecklist.Api.Controllers.Tasks
{
    public interface ITaskRepository
    {
        IEnumerable<ITaskModel> GetTasks();
        IEnumerable<UserTaskModel> GetUserTasks(string userId);
    }

    public class TaskRepository : ITaskRepository
    {
        XIVContext _context;
        IMapper _mapper;

        public TaskRepository(XIVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ITaskModel> GetTasks()
        {
            var achievementTasks = _context.AchievementTask
                .Include(x => x.AchievementType)
                .Include(x => x.Rewards);

            var bluCarnivaleTasks = _context.BLUCarnivaleTask;

            var bluLogTasks = _context.BLULogTask
                .Include(x => x.Content);

            var bluSpellTasks = _context.BLUSpellTask
                .Include(x => x.Locations);

            var collectionTasks = _context.CollectionTask
                .Include(x => x.CollectionType);

            var orchestrionTasks = _context.OrchestrionTask
                .Include(x => x.OrchestrionType);

            var relicWeaponTasks = _context.RelicWeaponTasks
                .Include(x => x.Discipline);

            var sightseeingLogTasks = _context.SightseeingLogTasks
                .Include(x => x.Patch);

            var huntingLogTasks = _context.HuntingLogTasks
                .Include(x => x.HuntingLogType)
                .Include(x => x.Mobs);

            var gatheringLogTasks = _context.GatheringLogTasks
                .Include(x => x.GatherType);

            var fishGuideTasks = _context.FishGuideTasks
                .Include(x => x.Zone);

            var craftingLogTasks = _context.CraftingLogTask
                .Include(x => x.CraftingLogType);

            var msqTasks = _context.MSQTasks
                .Include(x => x.MSQType);

            var pveTasks = _context.PvETasks
                .Include(x => x.Content);

            var leveTasks = _context.LeveTasks
                .Include(x => x.LeveType);

            var fateTasks = _context.FATETask;

            var sqTasks = _context.SidequestTasks
                .Include(x => x.SQType);

            var roleQuestTasks = _context.RoleQuestTasks
                .Include(x => x.JobRole);

            var classQuestTasks = _context.ClassQuestTasks
                .Include(x => x.Discipline);

            var beastQuestTasks = _context.BeastQuestTasks
                .Include(x => x.BeastTribe)
                .Include(x => x.BeastRank);

            var theHuntTasks = _context.TheHuntTasks;

            var opponentTasks = _context.OpponentTasks;

            var cardTasks = _context.CardTasks;

            var tasks = new List<ITaskModel>();

            AddRange<AchievementTask, AchievementTaskModel>(ref tasks, achievementTasks);
            AddRange<BLUCarnivaleTask, BLUCarnivaleTaskModel>(ref tasks, bluCarnivaleTasks);
            AddRange<BLULogTask, BLULogTaskModel>(ref tasks, bluLogTasks);
            AddRange<BLUSpellTask, BLUSpellTaskModel>(ref tasks, bluSpellTasks);
            AddRange<CollectionTask, CollectionTaskModel>(ref tasks, collectionTasks);
            AddRange<OrchestrionTask, OrchestrionTaskModel>(ref tasks, orchestrionTasks);
            AddRange<RelicWeaponTask, RelicWeaponTaskModel>(ref tasks, relicWeaponTasks);
            AddRange<SightseeingLogTask, SightseeingLogTaskModel>(ref tasks, sightseeingLogTasks);
            AddRange<HuntingLogTask, HuntingLogTaskModel>(ref tasks, huntingLogTasks);
            AddRange<GatheringLogTask, GatheringLogTaskModel>(ref tasks, gatheringLogTasks);
            AddRange<FishGuideTask, FishGuideTaskModel>(ref tasks, fishGuideTasks);
            AddRange<CraftingLogTask, CraftingLogTaskModel>(ref tasks, craftingLogTasks);
            AddRange<MSQTask, MSQTaskModel>(ref tasks, msqTasks);
            AddRange<PvETask, PvETaskModel>(ref tasks, pveTasks);
            AddRange<LeveTask, LeveTaskModel>(ref tasks, leveTasks);
            AddRange<FATETask, FATETaskModel>(ref tasks, fateTasks);
            AddRange<SQTask, SQTaskModel>(ref tasks, sqTasks);
            AddRange<RoleQuestTask, RoleQuestTaskModel>(ref tasks, roleQuestTasks);
            AddRange<ClassQuestTask, ClassQuestTaskModel>(ref tasks, classQuestTasks);
            AddRange<BeastQuestTask, BeastQuestTaskModel>(ref tasks, beastQuestTasks);
            AddRange<TheHuntTask, TheHuntTaskModel>(ref tasks, theHuntTasks);
            AddRange<OpponentTask, OpponentTaskModel>(ref tasks, opponentTasks);
            AddRange<CardTask, CardTaskModel>(ref tasks, cardTasks);
            
            return tasks;
        }

        public IEnumerable<UserTaskModel> GetUserTasks(string userId)
        {
            var tasks = _context.UserTasks
                .Where(x => x.UserId == userId);

            return MapRange<UserTask, UserTaskModel>(tasks);
        }

        public void AddRange<Source, Dest>(ref List<ITaskModel> tasks, IEnumerable<Source> toAdd)
        {
            var add = toAdd.Select(x => _mapper.Map<Source, Dest>(x));

            tasks.AddRange((IEnumerable<ITaskModel>)add);
        }

        public IEnumerable<Dest> MapRange<Source, Dest>(IEnumerable<Source> tasks)
        {
            return tasks.Select(x => _mapper.Map<Source, Dest>(x));
        }
    }
}
