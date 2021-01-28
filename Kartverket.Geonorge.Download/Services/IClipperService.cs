﻿using System.Collections.Generic;
using Geonorge.NedlastingApi.V3;
using Kartverket.Geonorge.Download.Models;

namespace Kartverket.Geonorge.Download.Services
{
    public interface IClipperService
    {
        List<OrderItem> GetClippableOrderItems(OrderType incomingOrder, List<Eiendom> eiendoms = null);
        void SendClippingRequests(List<OrderItem> orderItems, string email);
    }
}