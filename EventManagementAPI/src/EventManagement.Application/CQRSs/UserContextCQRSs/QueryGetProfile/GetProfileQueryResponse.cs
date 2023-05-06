﻿using EventManagement.Application.ViewModels.UserContextViewModels;

namespace EventManagement.Application.CQRSs.UserContextCQRSs.QueryGetProfile
{
    public class GetProfileQueryResponse
    {
        public UserViewModel Profile { get; set; }

        public GetProfileQueryResponse(UserViewModel profile)
        {
            Profile = profile;
        }
    }
}
