using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MvvmLight003.Model;

namespace MvvmLight003.ViewModel
{
   public  class UserInfoViewModel:ViewModelBase
    {
        private UserInfoModel _userInfo;

        public UserInfoViewModel()
        {
            _userInfo = new UserInfoModel()
            {
                UserName = "wjj",
                UserAge = 32,
                UserPhone = 13777885123,
                UserSex = 2
            };
        }
        public UserInfoModel UserInfo
        {
            get => _userInfo;
            set
            {
                _userInfo = value;
                RaisePropertyChanged(() => _userInfo);
            }
        }
    }
}
