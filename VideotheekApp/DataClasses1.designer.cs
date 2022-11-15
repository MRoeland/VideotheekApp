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

namespace VideotheekApp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FilmDatabase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertVerhuur(Verhuur instance);
    partial void UpdateVerhuur(Verhuur instance);
    partial void DeleteVerhuur(Verhuur instance);
    partial void InsertLeden(Leden instance);
    partial void UpdateLeden(Leden instance);
    partial void DeleteLeden(Leden instance);
    partial void InsertVerhuurLijn(VerhuurLijn instance);
    partial void UpdateVerhuurLijn(VerhuurLijn instance);
    partial void DeleteVerhuurLijn(VerhuurLijn instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::VideotheekApp.Properties.Settings.Default.FilmDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Verhuur> Verhuurs
		{
			get
			{
				return this.GetTable<Verhuur>();
			}
		}
		
		public System.Data.Linq.Table<Leden> Ledens
		{
			get
			{
				return this.GetTable<Leden>();
			}
		}
		
		public System.Data.Linq.Table<VerhuurLijn> VerhuurLijns
		{
			get
			{
				return this.GetTable<VerhuurLijn>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Verhuur")]
	public partial class Verhuur : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _VerhuurId;
		
		private int _LidId;
		
		private System.DateTime _UitleenDatum;
		
		private System.Nullable<System.DateTime> _TerugDatum;
		
		private decimal _TotaalPrijs;
		
		private EntitySet<VerhuurLijn> _VerhuurLijns;
		
		private EntityRef<Leden> _Leden;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVerhuurIdChanging(int value);
    partial void OnVerhuurIdChanged();
    partial void OnLidIdChanging(int value);
    partial void OnLidIdChanged();
    partial void OnUitleenDatumChanging(System.DateTime value);
    partial void OnUitleenDatumChanged();
    partial void OnTerugDatumChanging(System.Nullable<System.DateTime> value);
    partial void OnTerugDatumChanged();
    partial void OnTotaalPrijsChanging(decimal value);
    partial void OnTotaalPrijsChanged();
    #endregion
		
		public Verhuur()
		{
			this._VerhuurLijns = new EntitySet<VerhuurLijn>(new Action<VerhuurLijn>(this.attach_VerhuurLijns), new Action<VerhuurLijn>(this.detach_VerhuurLijns));
			this._Leden = default(EntityRef<Leden>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VerhuurId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int VerhuurId
		{
			get
			{
				return this._VerhuurId;
			}
			set
			{
				if ((this._VerhuurId != value))
				{
					this.OnVerhuurIdChanging(value);
					this.SendPropertyChanging();
					this._VerhuurId = value;
					this.SendPropertyChanged("VerhuurId");
					this.OnVerhuurIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LidId", DbType="Int NOT NULL")]
		public int LidId
		{
			get
			{
				return this._LidId;
			}
			set
			{
				if ((this._LidId != value))
				{
					if (this._Leden.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLidIdChanging(value);
					this.SendPropertyChanging();
					this._LidId = value;
					this.SendPropertyChanged("LidId");
					this.OnLidIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UitleenDatum", DbType="DateTime NOT NULL")]
		public System.DateTime UitleenDatum
		{
			get
			{
				return this._UitleenDatum;
			}
			set
			{
				if ((this._UitleenDatum != value))
				{
					this.OnUitleenDatumChanging(value);
					this.SendPropertyChanging();
					this._UitleenDatum = value;
					this.SendPropertyChanged("UitleenDatum");
					this.OnUitleenDatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TerugDatum", DbType="DateTime")]
		public System.Nullable<System.DateTime> TerugDatum
		{
			get
			{
				return this._TerugDatum;
			}
			set
			{
				if ((this._TerugDatum != value))
				{
					this.OnTerugDatumChanging(value);
					this.SendPropertyChanging();
					this._TerugDatum = value;
					this.SendPropertyChanged("TerugDatum");
					this.OnTerugDatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotaalPrijs", DbType="Money NOT NULL")]
		public decimal TotaalPrijs
		{
			get
			{
				return this._TotaalPrijs;
			}
			set
			{
				if ((this._TotaalPrijs != value))
				{
					this.OnTotaalPrijsChanging(value);
					this.SendPropertyChanging();
					this._TotaalPrijs = value;
					this.SendPropertyChanged("TotaalPrijs");
					this.OnTotaalPrijsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Verhuur_VerhuurLijn", Storage="_VerhuurLijns", ThisKey="VerhuurId", OtherKey="VerhuurId")]
		public EntitySet<VerhuurLijn> VerhuurLijns
		{
			get
			{
				return this._VerhuurLijns;
			}
			set
			{
				this._VerhuurLijns.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Leden_Verhuur", Storage="_Leden", ThisKey="LidId", OtherKey="Id", IsForeignKey=true)]
		public Leden Leden
		{
			get
			{
				return this._Leden.Entity;
			}
			set
			{
				Leden previousValue = this._Leden.Entity;
				if (((previousValue != value) 
							|| (this._Leden.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Leden.Entity = null;
						previousValue.Verhuurs.Remove(this);
					}
					this._Leden.Entity = value;
					if ((value != null))
					{
						value.Verhuurs.Add(this);
						this._LidId = value.Id;
					}
					else
					{
						this._LidId = default(int);
					}
					this.SendPropertyChanged("Leden");
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
		
		private void attach_VerhuurLijns(VerhuurLijn entity)
		{
			this.SendPropertyChanging();
			entity.Verhuur = this;
		}
		
		private void detach_VerhuurLijns(VerhuurLijn entity)
		{
			this.SendPropertyChanging();
			entity.Verhuur = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Leden")]
	public partial class Leden : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Naam;
		
		private string _Adres;
		
		private string _TelNr;
		
		private string _Email;
		
		private EntitySet<Verhuur> _Verhuurs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNaamChanging(string value);
    partial void OnNaamChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnTelNrChanging(string value);
    partial void OnTelNrChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Leden()
		{
			this._Verhuurs = new EntitySet<Verhuur>(new Action<Verhuur>(this.attach_Verhuurs), new Action<Verhuur>(this.detach_Verhuurs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naam", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Naam
		{
			get
			{
				return this._Naam;
			}
			set
			{
				if ((this._Naam != value))
				{
					this.OnNaamChanging(value);
					this.SendPropertyChanging();
					this._Naam = value;
					this.SendPropertyChanged("Naam");
					this.OnNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelNr", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string TelNr
		{
			get
			{
				return this._TelNr;
			}
			set
			{
				if ((this._TelNr != value))
				{
					this.OnTelNrChanging(value);
					this.SendPropertyChanging();
					this._TelNr = value;
					this.SendPropertyChanged("TelNr");
					this.OnTelNrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Leden_Verhuur", Storage="_Verhuurs", ThisKey="Id", OtherKey="LidId")]
		public EntitySet<Verhuur> Verhuurs
		{
			get
			{
				return this._Verhuurs;
			}
			set
			{
				this._Verhuurs.Assign(value);
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
		
		private void attach_Verhuurs(Verhuur entity)
		{
			this.SendPropertyChanging();
			entity.Leden = this;
		}
		
		private void detach_Verhuurs(Verhuur entity)
		{
			this.SendPropertyChanging();
			entity.Leden = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VerhuurLijn")]
	public partial class VerhuurLijn : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _VerhuurId;
		
		private int _FilmId;
		
		private decimal _Prijs;
		
		private EntityRef<Verhuur> _Verhuur;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVerhuurIdChanging(int value);
    partial void OnVerhuurIdChanged();
    partial void OnFilmIdChanging(int value);
    partial void OnFilmIdChanged();
    partial void OnPrijsChanging(decimal value);
    partial void OnPrijsChanged();
    #endregion
		
		public VerhuurLijn()
		{
			this._Verhuur = default(EntityRef<Verhuur>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VerhuurId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int VerhuurId
		{
			get
			{
				return this._VerhuurId;
			}
			set
			{
				if ((this._VerhuurId != value))
				{
					if (this._Verhuur.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnVerhuurIdChanging(value);
					this.SendPropertyChanging();
					this._VerhuurId = value;
					this.SendPropertyChanged("VerhuurId");
					this.OnVerhuurIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmId", DbType="Int NOT NULL")]
		public int FilmId
		{
			get
			{
				return this._FilmId;
			}
			set
			{
				if ((this._FilmId != value))
				{
					this.OnFilmIdChanging(value);
					this.SendPropertyChanging();
					this._FilmId = value;
					this.SendPropertyChanged("FilmId");
					this.OnFilmIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prijs", DbType="Money NOT NULL")]
		public decimal Prijs
		{
			get
			{
				return this._Prijs;
			}
			set
			{
				if ((this._Prijs != value))
				{
					this.OnPrijsChanging(value);
					this.SendPropertyChanging();
					this._Prijs = value;
					this.SendPropertyChanged("Prijs");
					this.OnPrijsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Verhuur_VerhuurLijn", Storage="_Verhuur", ThisKey="VerhuurId", OtherKey="VerhuurId", IsForeignKey=true)]
		public Verhuur Verhuur
		{
			get
			{
				return this._Verhuur.Entity;
			}
			set
			{
				Verhuur previousValue = this._Verhuur.Entity;
				if (((previousValue != value) 
							|| (this._Verhuur.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Verhuur.Entity = null;
						previousValue.VerhuurLijns.Remove(this);
					}
					this._Verhuur.Entity = value;
					if ((value != null))
					{
						value.VerhuurLijns.Add(this);
						this._VerhuurId = value.VerhuurId;
					}
					else
					{
						this._VerhuurId = default(int);
					}
					this.SendPropertyChanged("Verhuur");
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
