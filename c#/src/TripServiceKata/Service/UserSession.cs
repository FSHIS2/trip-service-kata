﻿using TripServiceKata.Entity;
using TripServiceKata.Exception;

namespace TripServiceKata.Service
{
    public class UserSession : IUserSession {
        private static IUserSession userSession;

        public UserSession(IUserSession userSession) {
            UserSession.userSession = userSession;
        }

        public static IUserSession GetInstance()
        {
            return userSession;
        }

        public bool IsUserLoggedIn(User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                "UserSession.IsUserLoggedIn() should not be called in an unit test");
        }

        public User GetLoggedUser()
        {
            throw new DependendClassCallDuringUnitTestException(
                "UserSession.GetLoggedUser() should not be called in an unit test");
        }
    }
}