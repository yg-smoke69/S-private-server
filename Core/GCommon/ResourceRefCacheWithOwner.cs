using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040F8")]
public class ResourceRefCacheWithOwner : ResourceRefCacheWithOwnerNoRefCnt
{
	[Token(Token = "0x20040F9")]
	protected class ObjectRef
	{
		[Token(Token = "0x401B4DC")]
		[FieldOffset(Offset = "0x8")]
		public Object Res;

		[Token(Token = "0x401B4DD")]
		[FieldOffset(Offset = "0xC")]
		public ResourceID ResID;

		[Token(Token = "0x401B4DE")]
		[FieldOffset(Offset = "0x10")]
		public LinkedList<ResourceID> ResIDList;

		[Token(Token = "0x401B4DF")]
		[FieldOffset(Offset = "0x14")]
		public short RefCnt;

		[Token(Token = "0x601A84B")]
		[Address(RVA = "0x322DC74", Offset = "0x322DC74", VA = "0x322DC74")]
		public ObjectRef()
		{
		}

		[Token(Token = "0x601A84C")]
		[Address(RVA = "0x322EA60", Offset = "0x322EA60", VA = "0x322EA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x401B4D6")]
	private const object AnonymousOwner = null;

	[Token(Token = "0x401B4D7")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<ResourceID, ObjectRef> m_IdToRef;

	[Token(Token = "0x401B4D8")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Object, ObjectRef> m_ResToRefs;

	[Token(Token = "0x401B4D9")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<object, HashSet<ObjectRef>> m_OwnerToRef;

	[Token(Token = "0x401B4DA")]
	[FieldOffset(Offset = "0x20")]
	private List<ObjectRef> m_PendingUnloadReses;

	[Token(Token = "0x401B4DB")]
	private const bool SkipUnloadingWhileAsyncLoading = true;

	[Token(Token = "0x17001D0E")]
	public override bool NoCache
	{
		[Token(Token = "0x601A836")]
		[Address(RVA = "0x322C428", Offset = "0x322C428", VA = "0x322C428", Slot = "20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A837")]
		[Address(RVA = "0x322C430", Offset = "0x322C430", VA = "0x322C430", Slot = "21")]
		set
		{
		}
	}

	[Token(Token = "0x601A835")]
	[Address(RVA = "0x322C2F8", Offset = "0x322C2F8", VA = "0x322C2F8")]
	public ResourceRefCacheWithOwner()
	{
	}

	[Token(Token = "0x601A838")]
	[Address(RVA = "0x322C4BC", Offset = "0x322C4BC", VA = "0x322C4BC", Slot = "22")]
	public override void Clear()
	{
	}

	[Token(Token = "0x601A839")]
	[Address(RVA = "0x322C5DC", Offset = "0x322C5DC", VA = "0x322C5DC", Slot = "23")]
	public override Object TryGet(ResourceID resId)
	{
		return null;
	}

	[Token(Token = "0x601A83A")]
	[Address(RVA = "0x322C694", Offset = "0x322C694", VA = "0x322C694", Slot = "24")]
	public override Object GetAndRegister(object owner, ResourceID resId)
	{
		return null;
	}

	[Token(Token = "0x601A83B")]
	[Address(RVA = "0x322CC40", Offset = "0x322CC40", VA = "0x322CC40", Slot = "26")]
	public override void Register(object owner, Object res)
	{
	}

	[Token(Token = "0x601A83C")]
	[Address(RVA = "0x322C988", Offset = "0x322C988", VA = "0x322C988")]
	protected ObjectRef Register(object owner, ResourceID resId, Object res)
	{
		return null;
	}

	[Token(Token = "0x601A83D")]
	[Address(RVA = "0x322CE04", Offset = "0x322CE04", VA = "0x322CE04", Slot = "27")]
	public override void UnRegister(object owner, Object res)
	{
	}

	[Token(Token = "0x601A83E")]
	[Address(RVA = "0x322D19C", Offset = "0x322D19C", VA = "0x322D19C", Slot = "28")]
	public override void UnRegisterAll(object owner)
	{
	}

	[Token(Token = "0x601A83F")]
	[Address(RVA = "0x322D5A0", Offset = "0x322D5A0", VA = "0x322D5A0", Slot = "25")]
	public override bool HasUnRefedRes()
	{
		return default(bool);
	}

	[Token(Token = "0x601A840")]
	[Address(RVA = "0x322D628", Offset = "0x322D628", VA = "0x322D628", Slot = "29")]
	public override bool UnloadOneUnRefedRes()
	{
		return default(bool);
	}

	[Token(Token = "0x601A841")]
	[Address(RVA = "0x322DAE0", Offset = "0x322DAE0", VA = "0x322DAE0", Slot = "30")]
	public override int UnloadAllUnRefedRes()
	{
		return default(int);
	}

	[Token(Token = "0x601A842")]
	[Address(RVA = "0x322CCF0", Offset = "0x322CCF0", VA = "0x322CCF0")]
	private ObjectRef GetObjRef(Object res, bool create)
	{
		return null;
	}

	[Token(Token = "0x601A843")]
	[Address(RVA = "0x322DD14", Offset = "0x322DD14", VA = "0x322DD14")]
	private HashSet<ObjectRef> GetOwnerSet(object owner, bool create)
	{
		return null;
	}

	[Token(Token = "0x601A844")]
	[Address(RVA = "0x322D338", Offset = "0x322D338", VA = "0x322D338")]
	private HashSet<ObjectRef> GetAndRemoveOwnerSet(object owner)
	{
		return null;
	}

	[Token(Token = "0x601A845")]
	[Address(RVA = "0x322C7D4", Offset = "0x322C7D4", VA = "0x322C7D4")]
	private bool IncreaseRefInNeed(ObjectRef objRef, object owner)
	{
		return default(bool);
	}

	[Token(Token = "0x601A846")]
	[Address(RVA = "0x322D0E0", Offset = "0x322D0E0", VA = "0x322D0E0")]
	private bool DecreaseRefInNeed(ObjectRef objRef, object owner)
	{
		return default(bool);
	}

	[Token(Token = "0x601A847")]
	[Address(RVA = "0x322D408", Offset = "0x322D408", VA = "0x322D408")]
	private void DecreaseRef(ObjectRef objRef)
	{
	}

	[Token(Token = "0x601A848")]
	[Address(RVA = "0x322D7B8", Offset = "0x322D7B8", VA = "0x322D7B8")]
	private bool TryUnloadRes(ObjectRef objRef)
	{
		return default(bool);
	}

	[Token(Token = "0x601A849")]
	[Address(RVA = "0x322DE28", Offset = "0x322DE28", VA = "0x322DE28", Slot = "31")]
	public override uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, Object> callback)
	{
		return default(uint);
	}

	[Token(Token = "0x601A84A")]
	[Address(RVA = "0x322E08C", Offset = "0x322E08C", VA = "0x322E08C", Slot = "32")]
	protected override void RemoveAndInvokeAsyncCallback(uint ticket, bool success, Object obj)
	{
	}
}
