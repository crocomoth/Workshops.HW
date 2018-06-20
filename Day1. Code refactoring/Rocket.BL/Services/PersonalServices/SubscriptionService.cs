using System.Linq;
using Rocket.BL.Common.Services.PersonalArea;
using Rocket.DAL.Common.DbModels.User;
using Rocket.DAL.Common.UoW;

namespace Rocket.BL.Services.PersonalServices
{
    public class SubscriptionService : BaseService, ISubscriptionService
    {
        public SubscriptionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void Subscribe(string userId, int id)
        {
            var user = _unitOfWork.UserRepository.Get(f => f.Id == userId, includeProperties: $"{nameof(DbUser.Subscriptions)}")
                .FirstOrDefault();
            var subscription = _unitOfWork.SubscribableRepository.GetById(id);
            if (user != null && subscription != null && !user.Subscriptions.Contains(subscription))
            {
                user.Subscriptions.Add(subscription);
            }

            _unitOfWork.SaveChanges();
        }

        public void Unsubscribe(string userId, int id)
        {
            var user = _unitOfWork.UserRepository.Get(f => f.Id == userId, includeProperties: $"{nameof(DbUser.Subscriptions)}")
                .FirstOrDefault();
            var subscription = _unitOfWork.SubscribableRepository.GetById(id);
            if (user != null && subscription != null && user.Subscriptions.Contains(subscription))
            {
                user.Subscriptions.Remove(subscription);
            }

            _unitOfWork.SaveChanges();
        }
    }
}
