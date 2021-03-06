﻿using System;
using Binance.WebSocket.Events;

namespace Binance.WebSocket
{
    public interface ITradeWebSocketClient : IBinanceWebSocketClient
    {
        #region Events

        /// <summary>
        /// The trade event.
        /// </summary>
        event EventHandler<TradeEventArgs> Trade;

        #endregion Events

        #region Methods

        /// <summary>
        /// Subscribe to the specified symbol (for use with combined streams).
        /// Call <see cref="IWebSocketStream"/> StreamAsync to begin streaming.
        /// </summary>
        /// <param name="symbol">The symbol to subscribe.</param>
        /// <param name="callback">An event callback.</param>
        void Subscribe(string symbol, Action<TradeEventArgs> callback);

        #endregion Methods
    }
}
