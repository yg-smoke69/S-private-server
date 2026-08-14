using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040F6")]
public class ResourceRefCacheWithOwnerNoRefCnt : _Attribute
{
	[Token(Token = "0x20040F7")]
	public class ResCallbackPair
	{
		[Token(Token = "0x401B4D4")]
		[FieldOffset(Offset = "0x8")]
		public ResourceID ResId;

		[Token(Token = "0x401B4D5")]
		[FieldOffset(Offset = "0xC")]
		public Action<uint, Object> Callback;

		[Token(Token = "0x601A834")]
		[Address(RVA = "0x32301C0", Offset = "0x32301C0", VA = "0x32301C0")]
		public ResCallbackPair(ResourceID resId, Action<uint, Object> callback)
		{
		}
	}

	[Token(Token = "0x401B4D0")]
	[FieldOffset(Offset = "0x8")]
	private bool _003CNoCache_003Ek__BackingField;

	[Token(Token = "0x401B4D1")]
	private const int OwnerRequestsDefaultCapacity = 1;

	[Token(Token = "0x401B4D2")]
	[FieldOffset(Offset = "0xC")]
	protected Dictionary<object, Dictionary<uint, ResCallbackPair>> m_OwnerToRequests;

	[Token(Token = "0x401B4D3")]
	[FieldOffset(Offset = "0x10")]
	protected Dictionary<uint, object> m_TicketToOwner;

	[Token(Token = "0x17001D0D")]
	public virtual bool NoCache
	{
		[Token(Token = "0x601A813")]
		[Address(RVA = "0x322EE04", Offset = "0x322EE04", VA = "0x322EE04", Slot = "20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A814")]
		[Address(RVA = "0x322EE0C", Offset = "0x322EE0C", VA = "0x322EE0C", Slot = "21")]
		set
		{
		}
	}

	[Token(Token = "0x601A812")]
	[Address(RVA = "0x322C420", Offset = "0x322C420", VA = "0x322C420")]
	public ResourceRefCacheWithOwnerNoRefCnt()
	{
	}

	[Token(Token = "0x601A815")]
	[Address(RVA = "0x322C5CC", Offset = "0x322C5CC", VA = "0x322C5CC", Slot = "22")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x601A816")]
	[Address(RVA = "0x322EE14", Offset = "0x322EE14", VA = "0x322EE14", Slot = "23")]
	public virtual Object TryGet(ResourceID resId)
	{
		return null;
	}

	[Token(Token = "0x601A817")]
	[Address(RVA = "0x322EEC4", Offset = "0x322EEC4", VA = "0x322EEC4", Slot = "24")]
	public virtual Object GetAndRegister(object owner, ResourceID resId)
	{
		return null;
	}

	[Token(Token = "0x601A818")]
	[Address(RVA = "0x322C8B4", Offset = "0x322C8B4", VA = "0x322C8B4")]
	protected static Object LoadImpl(ResourceID resId, bool noCache)
	{
		return null;
	}

	[Token(Token = "0x601A819")]
	[Address(RVA = "0x322EEF0", Offset = "0x322EEF0", VA = "0x322EEF0", Slot = "25")]
	public virtual bool HasUnRefedRes()
	{
		return default(bool);
	}

	[Token(Token = "0x601A81A")]
	[Address(RVA = "0x322EEF8", Offset = "0x322EEF8", VA = "0x322EEF8", Slot = "26")]
	public virtual void Register(object owner, Object res)
	{
	}

	[Token(Token = "0x601A81B")]
	[Address(RVA = "0x322EEFC", Offset = "0x322EEFC", VA = "0x322EEFC", Slot = "27")]
	public virtual void UnRegister(object owner, Object res)
	{
	}

	[Token(Token = "0x601A81C")]
	[Address(RVA = "0x322EF00", Offset = "0x322EF00", VA = "0x322EF00", Slot = "28")]
	public virtual void UnRegisterAll(object owner)
	{
	}

	[Token(Token = "0x601A81D")]
	[Address(RVA = "0x322EF04", Offset = "0x322EF04", VA = "0x322EF04", Slot = "29")]
	public virtual bool UnloadOneUnRefedRes()
	{
		return default(bool);
	}

	[Token(Token = "0x601A81E")]
	[Address(RVA = "0x322EF0C", Offset = "0x322EF0C", VA = "0x322EF0C", Slot = "30")]
	public virtual int UnloadAllUnRefedRes()
	{
		return default(int);
	}

	[Token(Token = "0x601A81F")]
	[Address(RVA = "0x322D734", Offset = "0x322D734", VA = "0x322D734", Slot = "13")]
	public bool IsAsyncLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x601A820")]
	[Address(RVA = "0x322EF14", Offset = "0x322EF14", VA = "0x322EF14", Slot = "14")]
	public bool IsAsyncLoading(object owner, ResourceID resId)
	{
		return default(bool);
	}

	[Token(Token = "0x601A821")]
	[Address(RVA = "0x322F260", Offset = "0x322F260", VA = "0x322F260")]
	protected static uint LoadAsyncImpl(uint ticket, ResourceID resId, Action<uint, bool, Object> callback, bool noCache)
	{
		return default(uint);
	}

	[Token(Token = "0x601A822")]
	[Address(RVA = "0x322F338", Offset = "0x322F338", VA = "0x322F338", Slot = "31")]
	public virtual uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, Object> callback)
	{
		return default(uint);
	}

	[Token(Token = "0x601A823")]
	[Address(RVA = "0x322DE4C", Offset = "0x322DE4C", VA = "0x322DE4C")]
	protected uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, Object> callback, bool checkCache)
	{
		return default(uint);
	}

	[Token(Token = "0x601A824")]
	[Address(RVA = "0x322F35C", Offset = "0x322F35C", VA = "0x322F35C", Slot = "32")]
	protected virtual void RemoveAndInvokeAsyncCallback(uint ticket, bool success, Object obj)
	{
	}

	[Token(Token = "0x601A825")]
	[Address(RVA = "0x322E634", Offset = "0x322E634", VA = "0x322E634")]
	protected void DoInvokeAsyncCallback(uint ticket, Object obj, ResCallbackPair pair)
	{
	}

	[Token(Token = "0x601A826")]
	[Address(RVA = "0x322F39C", Offset = "0x322F39C", VA = "0x322F39C", Slot = "33")]
	public virtual void CancelAsync(object owner, uint ticket)
	{
	}

	[Token(Token = "0x601A827")]
	[Address(RVA = "0x322FA9C", Offset = "0x322FA9C", VA = "0x322FA9C", Slot = "34")]
	public virtual void CancelAsyncs(object owner)
	{
	}

	[Token(Token = "0x601A828")]
	[Address(RVA = "0x322FC8C", Offset = "0x322FC8C", VA = "0x322FC8C", Slot = "35")]
	public virtual void CancelAllAsyncs()
	{
	}

	[Token(Token = "0x601A829")]
	[Address(RVA = "0x322FE5C", Offset = "0x322FE5C", VA = "0x322FE5C", Slot = "36")]
	public virtual void RemoveOwner(object owner)
	{
	}

	[Token(Token = "0x601A82A")]
	[Address(RVA = "0x322FAA4", Offset = "0x322FAA4", VA = "0x322FAA4")]
	protected void CancelAsyncs(object owner, bool remove)
	{
	}

	[Token(Token = "0x601A82B")]
	[Address(RVA = "0x322F9EC", Offset = "0x322F9EC", VA = "0x322F9EC")]
	protected void DoCancelAsync(uint ticket)
	{
	}

	[Token(Token = "0x601A82C")]
	[Address(RVA = "0x322FF58", Offset = "0x322FF58", VA = "0x322FF58")]
	protected void AddTicketOwner(object owner, uint ticket)
	{
	}

	[Token(Token = "0x601A82D")]
	[Address(RVA = "0x3230020", Offset = "0x3230020", VA = "0x3230020")]
	protected object GetAndRemoveTicketOwner(uint ticket)
	{
		return null;
	}

	[Token(Token = "0x601A82E")]
	[Address(RVA = "0x322F3D4", Offset = "0x322F3D4", VA = "0x322F3D4")]
	protected bool RemoveTicketOwner(uint ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x601A82F")]
	[Address(RVA = "0x322F0FC", Offset = "0x322F0FC", VA = "0x322F0FC")]
	protected Dictionary<uint, ResCallbackPair> GetAsyncCallbacks(object owner, bool create)
	{
		return null;
	}

	[Token(Token = "0x601A830")]
	[Address(RVA = "0x322FE90", Offset = "0x322FE90", VA = "0x322FE90")]
	protected Dictionary<uint, ResCallbackPair> RemoveAsyncCallbacks(object owner)
	{
		return null;
	}

	[Token(Token = "0x601A831")]
	[Address(RVA = "0x32300E8", Offset = "0x32300E8", VA = "0x32300E8", Slot = "37")]
	protected virtual void RegisterAsyncCallback(object owner, uint ticket, ResourceID resId, Action<uint, Object> callback)
	{
	}

	[Token(Token = "0x601A832")]
	[Address(RVA = "0x322E0FC", Offset = "0x322E0FC", VA = "0x322E0FC")]
	protected ResCallbackPair RemoveAsyncCallback(uint ticket, out object owner)
	{
		return null;
	}

	[Token(Token = "0x601A833")]
	[Address(RVA = "0x322F510", Offset = "0x322F510", VA = "0x322F510")]
	protected void RemoveAsyncCallback(object owner, uint ticket)
	{
	}
}
