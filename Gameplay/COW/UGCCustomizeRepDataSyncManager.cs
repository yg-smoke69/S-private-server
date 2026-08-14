using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002E3A")]
internal class UGCCustomizeRepDataSyncManager
{
	[Token(Token = "0x2002E3B")]
	private class EntityRepDataUnionKey : _Attribute
	{
		[Token(Token = "0x4011ACD")]
		[FieldOffset(Offset = "0x8")]
		public FONLAPPBCOO EntityType;

		[Token(Token = "0x4011ACE")]
		[FieldOffset(Offset = "0xC")]
		public string EntityID;

		[Token(Token = "0x6013557")]
		[Address(RVA = "0x233F6D8", Offset = "0x233F6D8", VA = "0x233F6D8")]
		public EntityRepDataUnionKey()
		{
		}

		[Token(Token = "0x6013558")]
		[Address(RVA = "0x2340C9C", Offset = "0x2340C9C", VA = "0x2340C9C", Slot = "4")]
		public int Compare(EntityRepDataUnionKey x, EntityRepDataUnionKey y)
		{
			return default(int);
		}

		[Token(Token = "0x6013559")]
		[Address(RVA = "0x2340E54", Offset = "0x2340E54", VA = "0x2340E54", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x601355A")]
		[Address(RVA = "0x2340F8C", Offset = "0x2340F8C", VA = "0x2340F8C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x601355B")]
		[Address(RVA = "0x23410B8", Offset = "0x23410B8", VA = "0x23410B8")]
		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return default(bool);
		}

		[Token(Token = "0x601355C")]
		[Address(RVA = "0x23410C0", Offset = "0x23410C0", VA = "0x23410C0")]
		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x4011AC7")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, int> _existEntitiesID;

	[Token(Token = "0x4011AC8")]
	[FieldOffset(Offset = "0xC")]
	private Action<FONLAPPBCOO, string> _onAddEntityEvent;

	[Token(Token = "0x4011AC9")]
	[FieldOffset(Offset = "0x10")]
	private Action<FONLAPPBCOO, string> _onRemoveEntityEvent;

	[Token(Token = "0x4011ACA")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<EntityRepDataUnionKey, Dictionary<int, object>> _allEntityRepDataItem;

	[Token(Token = "0x4011ACB")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<EntityRepDataUnionKey, Action<int, object, object>> _onRepDataChangeHandlers;

	[Token(Token = "0x4011ACC")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<string, GameObject> CacheEntityMap;

	[Token(Token = "0x6013547")]
	[Address(RVA = "0x233F4A0", Offset = "0x233F4A0", VA = "0x233F4A0")]
	public UGCCustomizeRepDataSyncManager()
	{
	}

	[Token(Token = "0x6013548")]
	[Address(RVA = "0x233F5D4", Offset = "0x233F5D4", VA = "0x233F5D4")]
	private EntityRepDataUnionKey GetEntityRepDataUnionKey(FONLAPPBCOO entityType, string entityID)
	{
		return null;
	}

	[Token(Token = "0x6013549")]
	[Address(RVA = "0x233F6E0", Offset = "0x233F6E0", VA = "0x233F6E0")]
	private object RepItem2Value(PKLDKEHJPCE repItemValue)
	{
		return null;
	}

	[Token(Token = "0x601354A")]
	[Address(RVA = "0x233FA2C", Offset = "0x233FA2C", VA = "0x233FA2C")]
	private void CheckEntityExistState(FONLAPPBCOO entityType, string entityID)
	{
	}

	[Token(Token = "0x601354B")]
	[Address(RVA = "0x233FB78", Offset = "0x233FB78", VA = "0x233FB78")]
	private void RemoveExistEntity(string entityID)
	{
	}

	[Token(Token = "0x601354C")]
	[Address(RVA = "0x233FCDC", Offset = "0x233FCDC", VA = "0x233FCDC")]
	public void OnUGCRepDataSyncDirtyDataset(ECDIOOMOKBP msg)
	{
	}

	[Token(Token = "0x601354D")]
	[Address(RVA = "0x2340240", Offset = "0x2340240", VA = "0x2340240")]
	public void RegisterAddEntityEvent(Action<FONLAPPBCOO, string> handler)
	{
	}

	[Token(Token = "0x601354E")]
	[Address(RVA = "0x234037C", Offset = "0x234037C", VA = "0x234037C")]
	public void UnRegisterAddEntityEvent(Action<FONLAPPBCOO, string> handler)
	{
	}

	[Token(Token = "0x601354F")]
	[Address(RVA = "0x23404B8", Offset = "0x23404B8", VA = "0x23404B8")]
	public void RegisterRemoveEntityEvent(Action<FONLAPPBCOO, string> handler)
	{
	}

	[Token(Token = "0x6013550")]
	[Address(RVA = "0x23405F4", Offset = "0x23405F4", VA = "0x23405F4")]
	public void UnRegisterRemoveEntityEvent(Action<FONLAPPBCOO, string> handler)
	{
	}

	[Token(Token = "0x6013551")]
	[Address(RVA = "0x2336B40", Offset = "0x2336B40", VA = "0x2336B40")]
	public void RegisterChangeEvent(FONLAPPBCOO entityType, string entityID, Action<int, object, object> handler)
	{
	}

	[Token(Token = "0x6013552")]
	[Address(RVA = "0x2336E94", Offset = "0x2336E94", VA = "0x2336E94")]
	public void UnRegisterChangeEvent(FONLAPPBCOO entityType, string entityID, Action<int, object, object> handler)
	{
	}

	[Token(Token = "0x6013553")]
	public T GetEntityRepItemValue<T>(FONLAPPBCOO entityType, string entityID, int repItemIndex)
	{
		return (T)null;
	}

	[Token(Token = "0x6013554")]
	[Address(RVA = "0x2340730", Offset = "0x2340730", VA = "0x2340730")]
	public void RegisterEntityGameObject(string entityID, GameObject obj)
	{
	}

	[Token(Token = "0x6013555")]
	[Address(RVA = "0x234087C", Offset = "0x234087C", VA = "0x234087C")]
	public GameObject TryGetEntityGameObject(string entityID)
	{
		return null;
	}

	[Token(Token = "0x6013556")]
	[Address(RVA = "0x2340AB0", Offset = "0x2340AB0", VA = "0x2340AB0")]
	public static string ConvertEntityIDFromSyncID(string str)
	{
		return null;
	}
}
