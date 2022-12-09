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

namespace LINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Calisma")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdvUrunler(AdvUrunler instance);
    partial void UpdateAdvUrunler(AdvUrunler instance);
    partial void DeleteAdvUrunler(AdvUrunler instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LINQ.Properties.Settings.Default.CalismaConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<AdvUrunler> AdvUrunlers
		{
			get
			{
				return this.GetTable<AdvUrunler>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdvUrunler")]
	public partial class AdvUrunler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ÜrünID;
		
		private string _ÜrünKodu;
		
		private string _Renk;
		
		private decimal _BirimFiyat;
		
		private string _ÜrünAdi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnÜrünIDChanging(int value);
    partial void OnÜrünIDChanged();
    partial void OnÜrünKoduChanging(string value);
    partial void OnÜrünKoduChanged();
    partial void OnRenkChanging(string value);
    partial void OnRenkChanged();
    partial void OnBirimFiyatChanging(decimal value);
    partial void OnBirimFiyatChanged();
    partial void OnÜrünAdiChanging(string value);
    partial void OnÜrünAdiChanged();
    #endregion
		
		public AdvUrunler()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ÜrünID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ÜrünID
		{
			get
			{
				return this._ÜrünID;
			}
			set
			{
				if ((this._ÜrünID != value))
				{
					this.OnÜrünIDChanging(value);
					this.SendPropertyChanging();
					this._ÜrünID = value;
					this.SendPropertyChanged("ÜrünID");
					this.OnÜrünIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ÜrünKodu", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ÜrünKodu
		{
			get
			{
				return this._ÜrünKodu;
			}
			set
			{
				if ((this._ÜrünKodu != value))
				{
					this.OnÜrünKoduChanging(value);
					this.SendPropertyChanging();
					this._ÜrünKodu = value;
					this.SendPropertyChanged("ÜrünKodu");
					this.OnÜrünKoduChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Renk", DbType="NVarChar(15)")]
		public string Renk
		{
			get
			{
				return this._Renk;
			}
			set
			{
				if ((this._Renk != value))
				{
					this.OnRenkChanging(value);
					this.SendPropertyChanging();
					this._Renk = value;
					this.SendPropertyChanged("Renk");
					this.OnRenkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirimFiyat", DbType="Money NOT NULL")]
		public decimal BirimFiyat
		{
			get
			{
				return this._BirimFiyat;
			}
			set
			{
				if ((this._BirimFiyat != value))
				{
					this.OnBirimFiyatChanging(value);
					this.SendPropertyChanging();
					this._BirimFiyat = value;
					this.SendPropertyChanged("BirimFiyat");
					this.OnBirimFiyatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ÜrünAdi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ÜrünAdi
		{
			get
			{
				return this._ÜrünAdi;
			}
			set
			{
				if ((this._ÜrünAdi != value))
				{
					this.OnÜrünAdiChanging(value);
					this.SendPropertyChanging();
					this._ÜrünAdi = value;
					this.SendPropertyChanged("ÜrünAdi");
					this.OnÜrünAdiChanged();
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
