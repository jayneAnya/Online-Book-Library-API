﻿using PioneerOnlineLibrary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Infrastructure.Interface
{
    public interface IReview
    {
        Review AddComment(Review review);
        Review AddRating(Review rating);
    }
}