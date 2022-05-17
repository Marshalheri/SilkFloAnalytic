using SilkFloAnalytic.Data;
using SilkFloAnalytic.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SilkFloAnalytic.Stores.UserStore
{
    public class UserStore
    {
        private readonly IDataService _dataService;
        private IEnumerable<User> _users;
        public UserStore(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return _users;
        }

        public async Task FetUsersAsync()
        {
            this._users = await _dataService.GetUsers();
            BroadcastStateChange();
        }


        #region observer pattern
        //////////////////////////
        ///

        private Action _listeners;

        public void AddStateChangeListener(Action listener)
        {
            _listeners += listener;
        }
        
        public void RemoveStateChangeListener(Action listener)
        {
            _listeners -= listener;
        }

        private void BroadcastStateChange()
        {
            _listeners.Invoke();
        }
        #endregion
    }
}
