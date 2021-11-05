﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MilliGame")]
	public partial class DataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertContact(Contact instance);
    partial void UpdateContact(Contact instance);
    partial void DeleteContact(Contact instance);
    partial void InsertMehsullar(Mehsullar instance);
    partial void UpdateMehsullar(Mehsullar instance);
    partial void DeleteMehsullar(Mehsullar instance);
    partial void InsertAdminInfo(AdminInfo instance);
    partial void UpdateAdminInfo(AdminInfo instance);
    partial void DeleteAdminInfo(AdminInfo instance);
    #endregion
		
		public DataClassDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MilliGameConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Contact> Contacts
		{
			get
			{
				return this.GetTable<Contact>();
			}
		}
		
		public System.Data.Linq.Table<Mehsullar> Mehsullars
		{
			get
			{
				return this.GetTable<Mehsullar>();
			}
		}
		
		public System.Data.Linq.Table<AdminInfo> AdminInfos
		{
			get
			{
				return this.GetTable<AdminInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contacts")]
	public partial class Contact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ConId;
		
		private string _ConMessage;
		
		private string _ConName;
		
		private string _ConMail;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnConIdChanging(int value);
    partial void OnConIdChanged();
    partial void OnConMessageChanging(string value);
    partial void OnConMessageChanged();
    partial void OnConNameChanging(string value);
    partial void OnConNameChanged();
    partial void OnConMailChanging(string value);
    partial void OnConMailChanged();
    #endregion
		
		public Contact()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ConId
		{
			get
			{
				return this._ConId;
			}
			set
			{
				if ((this._ConId != value))
				{
					this.OnConIdChanging(value);
					this.SendPropertyChanging();
					this._ConId = value;
					this.SendPropertyChanged("ConId");
					this.OnConIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConMessage", DbType="NVarChar(MAX)")]
		public string ConMessage
		{
			get
			{
				return this._ConMessage;
			}
			set
			{
				if ((this._ConMessage != value))
				{
					this.OnConMessageChanging(value);
					this.SendPropertyChanging();
					this._ConMessage = value;
					this.SendPropertyChanged("ConMessage");
					this.OnConMessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConName", DbType="NVarChar(50)")]
		public string ConName
		{
			get
			{
				return this._ConName;
			}
			set
			{
				if ((this._ConName != value))
				{
					this.OnConNameChanging(value);
					this.SendPropertyChanging();
					this._ConName = value;
					this.SendPropertyChanged("ConName");
					this.OnConNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConMail", DbType="VarChar(50)")]
		public string ConMail
		{
			get
			{
				return this._ConMail;
			}
			set
			{
				if ((this._ConMail != value))
				{
					this.OnConMailChanging(value);
					this.SendPropertyChanging();
					this._ConMail = value;
					this.SendPropertyChanged("ConMail");
					this.OnConMailChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mehsullar")]
	public partial class Mehsullar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MehsulId;
		
		private string _MehsulShekil;
		
		private string _MehsulAd;
		
		private System.Nullable<int> _MehsulQiymet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMehsulIdChanging(int value);
    partial void OnMehsulIdChanged();
    partial void OnMehsulShekilChanging(string value);
    partial void OnMehsulShekilChanged();
    partial void OnMehsulAdChanging(string value);
    partial void OnMehsulAdChanged();
    partial void OnMehsulQiymetChanging(System.Nullable<int> value);
    partial void OnMehsulQiymetChanged();
    #endregion
		
		public Mehsullar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MehsulId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MehsulId
		{
			get
			{
				return this._MehsulId;
			}
			set
			{
				if ((this._MehsulId != value))
				{
					this.OnMehsulIdChanging(value);
					this.SendPropertyChanging();
					this._MehsulId = value;
					this.SendPropertyChanged("MehsulId");
					this.OnMehsulIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MehsulShekil", DbType="VarChar(50)")]
		public string MehsulShekil
		{
			get
			{
				return this._MehsulShekil;
			}
			set
			{
				if ((this._MehsulShekil != value))
				{
					this.OnMehsulShekilChanging(value);
					this.SendPropertyChanging();
					this._MehsulShekil = value;
					this.SendPropertyChanged("MehsulShekil");
					this.OnMehsulShekilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MehsulAd", DbType="NVarChar(50)")]
		public string MehsulAd
		{
			get
			{
				return this._MehsulAd;
			}
			set
			{
				if ((this._MehsulAd != value))
				{
					this.OnMehsulAdChanging(value);
					this.SendPropertyChanging();
					this._MehsulAd = value;
					this.SendPropertyChanged("MehsulAd");
					this.OnMehsulAdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MehsulQiymet", DbType="Int")]
		public System.Nullable<int> MehsulQiymet
		{
			get
			{
				return this._MehsulQiymet;
			}
			set
			{
				if ((this._MehsulQiymet != value))
				{
					this.OnMehsulQiymetChanging(value);
					this.SendPropertyChanging();
					this._MehsulQiymet = value;
					this.SendPropertyChanged("MehsulQiymet");
					this.OnMehsulQiymetChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdminInfo")]
	public partial class AdminInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdminId;
		
		private string _AdminName;
		
		private string _AdminPassword;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIdChanging(int value);
    partial void OnAdminIdChanged();
    partial void OnAdminNameChanging(string value);
    partial void OnAdminNameChanged();
    partial void OnAdminPasswordChanging(string value);
    partial void OnAdminPasswordChanged();
    #endregion
		
		public AdminInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdminId
		{
			get
			{
				return this._AdminId;
			}
			set
			{
				if ((this._AdminId != value))
				{
					this.OnAdminIdChanging(value);
					this.SendPropertyChanging();
					this._AdminId = value;
					this.SendPropertyChanged("AdminId");
					this.OnAdminIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminName", DbType="NVarChar(50)")]
		public string AdminName
		{
			get
			{
				return this._AdminName;
			}
			set
			{
				if ((this._AdminName != value))
				{
					this.OnAdminNameChanging(value);
					this.SendPropertyChanging();
					this._AdminName = value;
					this.SendPropertyChanged("AdminName");
					this.OnAdminNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminPassword", DbType="NVarChar(50)")]
		public string AdminPassword
		{
			get
			{
				return this._AdminPassword;
			}
			set
			{
				if ((this._AdminPassword != value))
				{
					this.OnAdminPasswordChanging(value);
					this.SendPropertyChanging();
					this._AdminPassword = value;
					this.SendPropertyChanged("AdminPassword");
					this.OnAdminPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
