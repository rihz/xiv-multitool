using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Extensions;
using XIVChecklist.Data.Context;
using Multi = XIVMultitool.Entities.XIVMultitool;

namespace XIVMultitool.Api.Controllers.Account.Retainer
{
    public interface IRetainerRepository
    {
        IEnumerable<RetainerModel> GetRetainers(string userId);
        RetainerModel AddRetainer(RetainerModel model);
        RetainerLabelModel AddRetainerLabel(RetainerLabelModel model);
        RetainerModel UpdateRetainer(RetainerModel model);
        RetainerLabelModel UpdateRetainerLabel(RetainerLabelModel model);
        void DeleteRetainer(int id);
        void DeleteRetainerLabel(int id);
    }

    public class RetainerRepository : IRetainerRepository
    {
        XIVContext _context;
        IMapper _mapper;

        public RetainerRepository(XIVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<RetainerModel> GetRetainers(string userId)
        {
            var retainers = _context.Retainers.Where(x => x.UserId == userId)
                .Include(x => x.Labels);

            return _mapper.MapEnumerable<Entities.XIVMultitool.Retainer, RetainerModel>(retainers);
        }

        public RetainerModel AddRetainer(RetainerModel model)
        {
            var entity = _mapper.Map<Entities.XIVMultitool.Retainer>(model);

            _context.Retainers.Add(entity);

            _context.SaveChanges();

            return _mapper.Map<RetainerModel>(entity);
        }

        public RetainerLabelModel AddRetainerLabel(RetainerLabelModel model)
        {
            var entity = _mapper.Map<Multi.RetainerLabel>(model);

            _context.RetainerLabels.Add(entity);

            _context.SaveChanges();

            return _mapper.Map<RetainerLabelModel>(entity);
        }

        public RetainerModel UpdateRetainer(RetainerModel model)
        {
            var entity = _mapper.Map<Entities.XIVMultitool.Retainer>(model);

            _context.Retainers.Update(entity);

            _context.SaveChanges();

            return _mapper.Map<RetainerModel>(entity);
        }

        public RetainerLabelModel UpdateRetainerLabel(RetainerLabelModel model)
        {
            var entity = _mapper.Map<Multi.RetainerLabel>(model);

            _context.RetainerLabels.Update(entity);

            _context.SaveChanges();

            return _mapper.Map<RetainerLabelModel>(entity);
        }

        public void DeleteRetainer(int id)
        {
            var entity = _context.Retainers.FirstOrDefault(x => x.Id == id);

            if(!entity.IsDefault())
            {
                _context.Retainers.Remove(entity);

                _context.SaveChanges();
            }
        }

        public void DeleteRetainerLabel(int id)
        {
            var entity = _context.RetainerLabels.FirstOrDefault(x => x.Id == id);

            if(!entity.IsDefault())
            {
                _context.RetainerLabels.Remove(entity);

                _context.SaveChanges();
            }
        }
    }
}
