using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.Account.Retainer
{
    public interface IRetainerService
    {
        IEnumerable<RetainerModel> GetRetainers(string userId);
        RetainerModel AddRetainer(RetainerModel model);
        RetainerLabelModel AddRetainerLabel(RetainerLabelModel model);
        RetainerModel UpdateRetainer(RetainerModel model);
        RetainerLabelModel UpdateRetainerLabel(RetainerLabelModel model);
        void DeleteRetainer(int id);
        void DeleteRetainerLabel(int id);
    }

    public class RetainerService : IRetainerService
    {
        IRetainerRepository _repo;

        public RetainerService(IRetainerRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<RetainerModel> GetRetainers(string userId)
        {
            return _repo.GetRetainers(userId);
        }

        public RetainerModel AddRetainer(RetainerModel model)
        {
            return _repo.AddRetainer(model);
        }

        public RetainerLabelModel AddRetainerLabel(RetainerLabelModel model)
        {
            return _repo.AddRetainerLabel(model);
        }

        public RetainerModel UpdateRetainer(RetainerModel model)
        {
            return _repo.UpdateRetainer(model);
        }

        public RetainerLabelModel UpdateRetainerLabel(RetainerLabelModel model)
        {
            return _repo.UpdateRetainerLabel(model);
        }

        public void DeleteRetainer(int id)
        {
            _repo.DeleteRetainer(id);
        }

        public void DeleteRetainerLabel(int id)
        {
            _repo.DeleteRetainerLabel(id);
        }
    }
}
