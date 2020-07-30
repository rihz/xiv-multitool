using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Controllers.Tasks.Enums;
using XIVChecklist.Api.Controllers.Tasks.Models;
using XIVChecklist.Data;
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
    public class TaskMapProfile : Profile
    {
        public TaskMapProfile()
        {
            CreateMap<AchievementTask, AchievementTaskModel>()
                .ForMember(d => d.AchievementTypeName, s => s.MapFrom(p => p.AchievementType.Name))
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.Achievement))
                .ForMember(d => d.Rewards, s => s.MapFrom(p => p.Rewards.Select(x => new AchievementRewardModel
                {
                    Id = x.Id,
                    AchievementId = x.AchievementId,
                    RewardTypeId = x.RewardTypeId,
                    RewardName = x.Reward
                })));

            CreateMap<BLUCarnivaleTask, BLUCarnivaleTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.BLUCarnivale))
                .ForMember(d => d.StandardTime, s => s.MapFrom(x => string.Format("{0}:{1}", x.StandardMinute, x.StandardSecond)))
                .ForMember(d => d.IdealTime, s => s.MapFrom(x => string.Format("{0}:{1}", x.IdealMinute, x.IdealSecond)));

            CreateMap<BLULogTask, BLULogTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.BLULog))
                .ForMember(d => d.ContentName, s => s.MapFrom(x => x.Content.Name));

            CreateMap<BLUSpellTask, BLUSpellTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.BLUSpell))
                .ForMember(d => d.Locations, s => s.MapFrom(x => x.Locations.Select(y => new BLUSpellLocationModel
                {
                    Id = y.Id,
                    Mob = y.MobName,
                    Location = y.LocationName
                })));

            CreateMap<CollectionTask, CollectionTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.Collection))
                .ForMember(d => d.CollectionTypeName, s => s.MapFrom(x => x.CollectionType.Name));

            CreateMap<OrchestrionTask, OrchestrionTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.Orchestrion))
                .ForMember(d => d.OrchestrionTypeName, s => s.MapFrom(x => x.OrchestrionType.Name));

            CreateMap<RelicWeaponTask, RelicWeaponTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.RelicWeapon))
                .ForMember(d => d.DisciplineName, s => s.MapFrom(x => x.Discipline.Name));

            CreateMap<SightseeingLogTask, SightseeingLogTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.SightseeingLog))
                .ForMember(d => d.PatchName, s => s.MapFrom(x => x.Patch.Name));

            CreateMap<HuntingLogTask, HuntingLogTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.HuntingLog))
                .ForMember(d => d.HuntingLogTypeName, s => s.MapFrom(x => x.HuntingLogType.Name))
                .ForMember(d => d.Mobs, s => s.MapFrom(x => x.Mobs.Select(y => new HuntingLogMobModel
                {
                    Id = y.Id,
                    HuntingLogId = y.HuntingLogId,
                    Location = y.Location,
                    Name = y.Name,
                    X = y.X,
                    Y = y.Y,
                    Zone = y.Zone
                })));

            CreateMap<GatheringLogTask, GatheringLogTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.GatheringLog))
                .ForMember(d => d.GatherTypeName, s => s.MapFrom(x => x.GatherType.Name));

            CreateMap<FishGuideTask, FishGuideTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.FishGuide))
                .ForMember(d => d.ZoneName, s => s.MapFrom(x => x.Zone.Name));

            CreateMap<FishingLogTask, FishingLogTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.FishingLog))
                .ForMember(d => d.ZoneName, s => s.MapFrom(x => x.Zone.Name));

            CreateMap<CraftingLogTask, CraftingLogTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.CraftingLog))
                .ForMember(d => d.CraftingLogTypeName, s => s.MapFrom(x => x.CraftingLogType.Name));

            CreateMap<MSQTask, MSQTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.MSQ))
                .ForMember(d => d.MSQTypeName, s => s.MapFrom(x => x.MSQType.Name));

            CreateMap<PvETask, PvETaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.PvE))
                .ForMember(d => d.ContentName, s => s.MapFrom(x => x.Content.Name));

            CreateMap<LeveTask, LeveTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.Leve))
                .ForMember(d => d.LeveTypeName, s => s.MapFrom(x => x.LeveType.Name));

            CreateMap<FATETask, FATETaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.FATE));

            CreateMap<SQTask, SQTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.SQ))
                .ForMember(d => d.SQTypeName, s => s.MapFrom(x => x.SQType.Name));

            CreateMap<RoleQuestTask, RoleQuestTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.RoleQuest))
                .ForMember(d => d.JobRoleName, s => s.MapFrom(x => x.JobRole.Name));

            CreateMap<ClassQuestTask, ClassQuestTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.ClassQuest))
                .ForMember(d => d.DisciplineName, s => s.MapFrom(x => x.Discipline.Name));

            CreateMap<BeastQuestTask, BeastQuestTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.BeastQuest))
                .ForMember(d => d.BeastTribeName, s => s.MapFrom(x => x.BeastTribe.Name))
                .ForMember(d => d.BeastRankName, s => s.MapFrom(x => x.BeastRank.Name));

            CreateMap<TheHuntTask, TheHuntTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.TheHunt));

            CreateMap<OpponentTask, OpponentTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.TTOpponent));

            CreateMap<CardTask, CardTaskModel>()
                .ForMember(d => d.TaskTypeId, s => s.UseValue(TaskType.TTCard));
        }
    }
}
