﻿using System;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie // : IHttpModule
    {
        /// <summary>
        /// Sie müssen dieses Modul in der Datei "Web.config" Ihres
        /// Webs konfigurieren und bei IIS registrieren, bevor Sie ihn verwenden können. Weitere Informationen
        /// finden Sie unter https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        //public void Dispose()
        //{
        //    //Bereinigungscode hier.
        //}

        //public void Init(HttpApplication context)
        //{
        //    // Unten finden Sie ein Beispiel, wie das Ereignis "LogRequest" verarbeitet und 
        //    // benutzerdefinierte Protokollierungsimplementierung bereitgestellt werden kann
        //    context.LogRequest += new EventHandler(OnLogRequest);
        //}

        #endregion

        //public void OnLogRequest(Object source, EventArgs e)
        //{
        //    //benutzerdefinierte Protokollierungslogik kann hier eingefügt werden
        //}

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
