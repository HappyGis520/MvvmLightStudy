/*******************************************************************
 * * 版权所有： 王建军
 * * 文件名称： UserInfoModel.cs
 * * 功   能：  Describet
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-04-02 11:57:23
 * * 修改记录： 
 * * 日期时间： 2018-04-02 11:57:23  修改人：王建军  创建
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
namespace MvvmLight003.Model
{
    public class UserInfoModel : ObservableObject
    {
        private string _userName;
        private Int32 _userSex;
        private Int32 _userAge;
        private Int64 _userPhone;

        public string UserName
        {
            get => _userName;
            set { _userName = value;
                RaisePropertyChanged(() => UserName); }
        }


        public Int32 UserSex
        {
            get => _userSex;
            set { _userSex = value;
                RaisePropertyChanged(() => UserSex); }
        }


        public int UserAge
        {
            get => _userAge;
            set
            {
                _userAge = value;
                RaisePropertyChanged(() => UserAge);
            }
        }

        public long UserPhone
        {
            get => _userPhone;
            set { _userPhone = value; RaisePropertyChanged(() => UserPhone); }

        }
    }
}