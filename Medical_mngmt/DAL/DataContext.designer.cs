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

namespace Medical_mngmt.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="medical")]
	public partial class DataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblPatient(tblPatient instance);
    partial void UpdatetblPatient(tblPatient instance);
    partial void DeletetblPatient(tblPatient instance);
    #endregion
		
		public DataContextDataContext() : 
				base(global::Medical_mngmt.Properties.Settings.Default.medicalConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblAdmin> tblAdmins
		{
			get
			{
				return this.GetTable<tblAdmin>();
			}
		}
		
		public System.Data.Linq.Table<tblPatient> tblPatients
		{
			get
			{
				return this.GetTable<tblPatient>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblAdmin")]
	public partial class tblAdmin
	{
		
		private System.Nullable<int> _User_Id;
		
		private string _Name;
		
		private string _Address;
		
		private string _Mobile_No;
		
		private string _Gender;
		
		private string _Email;
		
		private string _Password;
		
		public tblAdmin()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", DbType="Int")]
		public System.Nullable<int> User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					this._User_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile_No", DbType="Char(10)")]
		public string Mobile_No
		{
			get
			{
				return this._Mobile_No;
			}
			set
			{
				if ((this._Mobile_No != value))
				{
					this._Mobile_No = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblPatient")]
	public partial class tblPatient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Patient_Id;
		
		private string _Name;
		
		private string _Age;
		
		private string _Address;
		
		private string _Mobile_No;
		
		private string _Gender;
		
		private string _Email;
		
		private string _Blood_Group;
		
		private string _Symptoms;
		
		private string _Relative_Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPatient_IdChanging(int value);
    partial void OnPatient_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAgeChanging(string value);
    partial void OnAgeChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnMobile_NoChanging(string value);
    partial void OnMobile_NoChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnBlood_GroupChanging(string value);
    partial void OnBlood_GroupChanged();
    partial void OnSymptomsChanging(string value);
    partial void OnSymptomsChanged();
    partial void OnRelative_NameChanging(string value);
    partial void OnRelative_NameChanged();
    #endregion
		
		public tblPatient()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Patient_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Patient_Id
		{
			get
			{
				return this._Patient_Id;
			}
			set
			{
				if ((this._Patient_Id != value))
				{
					this.OnPatient_IdChanging(value);
					this.SendPropertyChanging();
					this._Patient_Id = value;
					this.SendPropertyChanged("Patient_Id");
					this.OnPatient_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Char(3)")]
		public string Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile_No", DbType="Char(10)")]
		public string Mobile_No
		{
			get
			{
				return this._Mobile_No;
			}
			set
			{
				if ((this._Mobile_No != value))
				{
					this.OnMobile_NoChanging(value);
					this.SendPropertyChanging();
					this._Mobile_No = value;
					this.SendPropertyChanged("Mobile_No");
					this.OnMobile_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Blood_Group", DbType="VarChar(50)")]
		public string Blood_Group
		{
			get
			{
				return this._Blood_Group;
			}
			set
			{
				if ((this._Blood_Group != value))
				{
					this.OnBlood_GroupChanging(value);
					this.SendPropertyChanging();
					this._Blood_Group = value;
					this.SendPropertyChanged("Blood_Group");
					this.OnBlood_GroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Symptoms", DbType="VarChar(50)")]
		public string Symptoms
		{
			get
			{
				return this._Symptoms;
			}
			set
			{
				if ((this._Symptoms != value))
				{
					this.OnSymptomsChanging(value);
					this.SendPropertyChanging();
					this._Symptoms = value;
					this.SendPropertyChanged("Symptoms");
					this.OnSymptomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Relative_Name", DbType="VarChar(50)")]
		public string Relative_Name
		{
			get
			{
				return this._Relative_Name;
			}
			set
			{
				if ((this._Relative_Name != value))
				{
					this.OnRelative_NameChanging(value);
					this.SendPropertyChanging();
					this._Relative_Name = value;
					this.SendPropertyChanged("Relative_Name");
					this.OnRelative_NameChanged();
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
