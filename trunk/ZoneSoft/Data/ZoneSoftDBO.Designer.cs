﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 04/07/2014 13:39:25
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace ZonesoftContext
{

    [DatabaseAttribute(Name = "zonesoft")]
    [ProviderAttribute(typeof(Devart.Data.MySql.Linq.Provider.MySqlDataProvider))]
    public partial class ZonesoftDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(ZonesoftDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertZoneSetting(ZoneSetting instance);
        partial void UpdateZoneSetting(ZoneSetting instance);
        partial void DeleteZoneSetting(ZoneSetting instance);
        partial void InsertZoneUser(ZoneUser instance);
        partial void UpdateZoneUser(ZoneUser instance);
        partial void DeleteZoneUser(ZoneUser instance);

        #endregion

        public ZonesoftDataContext() :
        base(GetConnectionString("ZonesoftDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        public ZonesoftDataContext(MappingSource mappingSource) :
        base(GetConnectionString("ZonesoftDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        private static string GetConnectionString(string connectionStringName)
        {
            System.Configuration.ConnectionStringSettings connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
                throw new InvalidOperationException("Connection string \"" + connectionStringName +"\" could not be found in the configuration file.");
            return connectionStringSettings.ConnectionString;
        }

        public ZonesoftDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public ZonesoftDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public ZonesoftDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public ZonesoftDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<ZoneSetting> ZoneSettings
        {
            get
            {
                return this.GetTable<ZoneSetting>();
            }
        }

        public Devart.Data.Linq.Table<ZoneUser> ZoneUsers
        {
            get
            {
                return this.GetTable<ZoneUser>();
            }
        }
    }
}

namespace ZonesoftContext
{

    /// <summary>
    /// There are no comments for ZonesoftContext.ZoneSetting in the schema.
    /// </summary>
    [Table(Name = @"zonesoft.zone_setting")]
    public partial class ZoneSetting : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _SettingId;

        private string _SettingName;

        private string _SettingNote;
        #pragma warning restore 0649
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnSettingIdChanging(int value);
        partial void OnSettingIdChanged();
        partial void OnSettingNameChanging(string value);
        partial void OnSettingNameChanged();
        partial void OnSettingNoteChanging(string value);
        partial void OnSettingNoteChanged();
        #endregion

        public ZoneSetting()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for SettingId in the schema.
        /// </summary>
        [Column(Name = @"setting_id", Storage = "_SettingId", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT(11) NOT NULL AUTO_INCREMENT", IsDbGenerated = true, IsPrimaryKey = true)]
        public int SettingId
        {
            get
            {
                return this._SettingId;
            }
            set
            {
                if (this._SettingId != value)
                {
                    this.OnSettingIdChanging(value);
                    this.SendPropertyChanging();
                    this._SettingId = value;
                    this.SendPropertyChanged("SettingId");
                    this.OnSettingIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for SettingName in the schema.
        /// </summary>
        [Column(Name = @"setting_name", Storage = "_SettingName", CanBeNull = false, DbType = "VARCHAR(100) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string SettingName
        {
            get
            {
                return this._SettingName;
            }
            set
            {
                if (this._SettingName != value)
                {
                    this.OnSettingNameChanging(value);
                    this.SendPropertyChanging();
                    this._SettingName = value;
                    this.SendPropertyChanged("SettingName");
                    this.OnSettingNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for SettingNote in the schema.
        /// </summary>
        [Column(Name = @"setting_note", Storage = "_SettingNote", CanBeNull = false, DbType = "VARCHAR(150) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string SettingNote
        {
            get
            {
                return this._SettingNote;
            }
            set
            {
                if (this._SettingNote != value)
                {
                    this.OnSettingNoteChanging(value);
                    this.SendPropertyChanging();
                    this._SettingNote = value;
                    this.SendPropertyChanged("SettingNote");
                    this.OnSettingNoteChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for ZonesoftContext.ZoneUser in the schema.
    /// </summary>
    [Table(Name = @"zonesoft.zone_user")]
    public partial class ZoneUser : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _UserId;

        private string _UserName;

        private string _UserPass;

        private sbyte _UserPublic = 1;

        private int _UserLevel = 1;

        private System.DateTime _UserCeatedate = DateTime.Now;
        #pragma warning restore 0649
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnUserIdChanging(int value);
        partial void OnUserIdChanged();
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
        partial void OnUserPassChanging(string value);
        partial void OnUserPassChanged();
        partial void OnUserPublicChanging(sbyte value);
        partial void OnUserPublicChanged();
        partial void OnUserLevelChanging(int value);
        partial void OnUserLevelChanged();
        partial void OnUserCeatedateChanging(System.DateTime value);
        partial void OnUserCeatedateChanged();
        #endregion

        public ZoneUser()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for UserId in the schema.
        /// </summary>
        [Column(Name = @"user_id", Storage = "_UserId", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT(11) NOT NULL AUTO_INCREMENT", IsDbGenerated = true, IsPrimaryKey = true)]
        public int UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                if (this._UserId != value)
                {
                    this.OnUserIdChanging(value);
                    this.SendPropertyChanging();
                    this._UserId = value;
                    this.SendPropertyChanged("UserId");
                    this.OnUserIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for UserName in the schema.
        /// </summary>
        [Column(Name = @"user_name", Storage = "_UserName", CanBeNull = false, DbType = "VARCHAR(100) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                if (this._UserName != value)
                {
                    this.OnUserNameChanging(value);
                    this.SendPropertyChanging();
                    this._UserName = value;
                    this.SendPropertyChanged("UserName");
                    this.OnUserNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for UserPass in the schema.
        /// </summary>
        [Column(Name = @"user_pass", Storage = "_UserPass", CanBeNull = false, DbType = "VARCHAR(150) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string UserPass
        {
            get
            {
                return this._UserPass;
            }
            set
            {
                if (this._UserPass != value)
                {
                    this.OnUserPassChanging(value);
                    this.SendPropertyChanging();
                    this._UserPass = value;
                    this.SendPropertyChanged("UserPass");
                    this.OnUserPassChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for UserPublic in the schema.
        /// </summary>
        [Column(Name = @"user_public", Storage = "_UserPublic", CanBeNull = false, DbType = "TINYINT(2) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public sbyte UserPublic
        {
            get
            {
                return this._UserPublic;
            }
            set
            {
                if (this._UserPublic != value)
                {
                    this.OnUserPublicChanging(value);
                    this.SendPropertyChanging();
                    this._UserPublic = value;
                    this.SendPropertyChanged("UserPublic");
                    this.OnUserPublicChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for UserLevel in the schema.
        /// </summary>
        [Column(Name = @"user_level", Storage = "_UserLevel", CanBeNull = false, DbType = "INT(10) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int UserLevel
        {
            get
            {
                return this._UserLevel;
            }
            set
            {
                if (this._UserLevel != value)
                {
                    this.OnUserLevelChanging(value);
                    this.SendPropertyChanging();
                    this._UserLevel = value;
                    this.SendPropertyChanged("UserLevel");
                    this.OnUserLevelChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for UserCeatedate in the schema.
        /// </summary>
        [Column(Name = @"user_ceatedate", Storage = "_UserCeatedate", CanBeNull = false, DbType = "TIMESTAMP NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.DateTime UserCeatedate
        {
            get
            {
                return this._UserCeatedate;
            }
            set
            {
                if (this._UserCeatedate != value)
                {
                    this.OnUserCeatedateChanging(value);
                    this.SendPropertyChanging();
                    this._UserCeatedate = value;
                    this.SendPropertyChanged("UserCeatedate");
                    this.OnUserCeatedateChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
