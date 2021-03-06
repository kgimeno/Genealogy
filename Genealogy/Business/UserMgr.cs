﻿/*****************************************************************************
 * Genealogy.Business.UserMgr
 * UserMgr to manage the work flow of the services related to User
 * @author Kelly J Gimeno
 * @version 1
 * @date 06/06/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Domain;

namespace Business
{
    public class UserMgr : Manager
    {
        public User getUser(User user)
        {
            try
            {
                IUserSvc userSvc = (IUserSvc)GetService(typeof(IUserSvc).Name);
                userSvc.getUser(user);
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End getUser(User user)

        public void addUser(User user)
        {
            try
            {
                IUserSvc userSvc = (IUserSvc)GetService(typeof(IUserSvc).Name);
                userSvc.addUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End addUser(User user, Login login)

        public void editUser(User user)
        {
            try
            {
                IUserSvc userSvc = (IUserSvc)GetService(typeof(IUserSvc).Name);
                userSvc.editUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End editUser(User user, Login login)

        public void deleteUser(User user)
        {
            try
            {
                IUserSvc userSvc = (IUserSvc)GetService(typeof(IUserSvc).Name);
                userSvc.deleteUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End deleteUser(User user, Login login)

    } // End UserMgr class

} // End Business namespace
