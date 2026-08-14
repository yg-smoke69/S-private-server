using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040E5")]
public class SpawnPool
{
	[Token(Token = "0x20040E6")]
	private class AsyncRequest
	{
		[Token(Token = "0x401B454")]
		[FieldOffset(Offset = "0x8")]
		public Transform Parent;

		[Token(Token = "0x401B455")]
		[FieldOffset(Offset = "0xC")]
		public int Count;

		[Token(Token = "0x401B456")]
		[FieldOffset(Offset = "0x10")]
		public bool IsForInit;

		[Token(Token = "0x401B457")]
		[FieldOffset(Offset = "0x14")]
		public Object CachedObject;

		[Token(Token = "0x401B458")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint, bool, Object> Callback;

		[Token(Token = "0x601A730")]
		[Address(RVA = "0x323646C", Offset = "0x323646C", VA = "0x323646C")]
		public AsyncRequest()
		{
		}
	}

	[Token(Token = "0x401B444")]
	[FieldOffset(Offset = "0x8")]
	private Queue<Object> m_FreeList;

	[Token(Token = "0x401B445")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_Parent;

	[Token(Token = "0x401B446")]
	[FieldOffset(Offset = "0x10")]
	private ResourceID m_resID;

	[Token(Token = "0x401B447")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 m_ResourceOrgScale;

	[Token(Token = "0x401B448")]
	[FieldOffset(Offset = "0x20")]
	private int m_GetResTimesTotal;

	[Token(Token = "0x401B449")]
	[FieldOffset(Offset = "0x24")]
	private int m_ReturnResTimesTotal;

	[Token(Token = "0x401B44A")]
	[FieldOffset(Offset = "0x28")]
	private int m_PoolSizeDynamicMax;

	[Token(Token = "0x401B44B")]
	[FieldOffset(Offset = "0x2C")]
	private int m_InstanceNewResTimes;

	[Token(Token = "0x401B44C")]
	[FieldOffset(Offset = "0x30")]
	private List<Object> m_ActiveList;

	[Token(Token = "0x401B44D")]
	[FieldOffset(Offset = "0x34")]
	private uint m_LimitMaxPoolSize;

	[Token(Token = "0x401B44E")]
	public const uint InvalidTicket = 0u;

	[Token(Token = "0x401B44F")]
	[FieldOffset(Offset = "0x0")]
	private static uint ticketGen;

	[Token(Token = "0x401B450")]
	[FieldOffset(Offset = "0x38")]
	private readonly Dictionary<uint, AsyncRequest> mAsyncRequestDict;

	[Token(Token = "0x401B451")]
	[FieldOffset(Offset = "0x3C")]
	private readonly Dictionary<uint, AsyncRequest> mAsyncRequestDictCached;

	[Token(Token = "0x401B452")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<AsyncRequest> mAsyncRequestPool;

	[Token(Token = "0x401B453")]
	[FieldOffset(Offset = "0x44")]
	private uint mCurAsyncResLoadTicket;

	[Token(Token = "0x17001CFD")]
	public static uint NewTicket
	{
		[Token(Token = "0x601A721")]
		[Address(RVA = "0x32361BC", Offset = "0x32361BC", VA = "0x32361BC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x601A71C")]
	[Address(RVA = "0x3235588", Offset = "0x3235588", VA = "0x3235588")]
	public SpawnPool(GameObject parent, ResourceID id)
	{
	}

	[Token(Token = "0x601A71D")]
	[Address(RVA = "0x32356F0", Offset = "0x32356F0", VA = "0x32356F0")]
	public void InitPool(int num, uint maxSize = 0u)
	{
	}

	[Token(Token = "0x601A71E")]
	[Address(RVA = "0x3235B38", Offset = "0x3235B38", VA = "0x3235B38")]
	public Object GetRes(Transform parentTrans)
	{
		return null;
	}

	[Token(Token = "0x601A71F")]
	[Address(RVA = "0x3235E5C", Offset = "0x3235E5C", VA = "0x3235E5C")]
	private void HandleObject(bool isNew, Object obj, Transform parentTrans)
	{
	}

	[Token(Token = "0x601A720")]
	[Address(RVA = "0x323612C", Offset = "0x323612C", VA = "0x323612C")]
	private void ResetTicketGen()
	{
	}

	[Token(Token = "0x601A722")]
	[Address(RVA = "0x3236250", Offset = "0x3236250", VA = "0x3236250")]
	private void RecycleRequest(AsyncRequest request)
	{
	}

	[Token(Token = "0x601A723")]
	[Address(RVA = "0x323634C", Offset = "0x323634C", VA = "0x323634C")]
	private AsyncRequest GetAsyncRequest()
	{
		return null;
	}

	[Token(Token = "0x601A724")]
	[Address(RVA = "0x323647C", Offset = "0x323647C", VA = "0x323647C")]
	public bool InitPoolAsync(int num, uint maxSize = 0u)
	{
		return default(bool);
	}

	[Token(Token = "0x601A725")]
	[Address(RVA = "0x323678C", Offset = "0x323678C", VA = "0x323678C")]
	public uint GetResAsync(Action<uint, bool, Object> callback, Transform parentTrans)
	{
		return default(uint);
	}

	[Token(Token = "0x601A726")]
	[Address(RVA = "0x3236B9C", Offset = "0x3236B9C", VA = "0x3236B9C")]
	public void UpdateCachedAsyncRequests()
	{
	}

	[Token(Token = "0x601A727")]
	[Address(RVA = "0x3236EB8", Offset = "0x3236EB8", VA = "0x3236EB8")]
	public void CancelResAsyncLoading(uint ticket)
	{
	}

	[Token(Token = "0x601A728")]
	[Address(RVA = "0x3237404", Offset = "0x3237404", VA = "0x3237404")]
	public void CancelAllResAsyncLoading()
	{
	}

	[Token(Token = "0x601A729")]
	[Address(RVA = "0x32377EC", Offset = "0x32377EC", VA = "0x32377EC")]
	private void HandleNewObject(uint ticket, bool succeeded, Object resObj)
	{
	}

	[Token(Token = "0x601A72A")]
	[Address(RVA = "0x32370E0", Offset = "0x32370E0", VA = "0x32370E0")]
	public void RecycleRes(Object obj, bool worldPositionStays = true)
	{
	}

	[Token(Token = "0x601A72B")]
	[Address(RVA = "0x3235A0C", Offset = "0x3235A0C", VA = "0x3235A0C")]
	public void HandleResEnqueue(Object obj)
	{
	}

	[Token(Token = "0x601A72C")]
	[Address(RVA = "0x3237F7C", Offset = "0x3237F7C", VA = "0x3237F7C")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A72D")]
	[Address(RVA = "0x32381A4", Offset = "0x32381A4", VA = "0x32381A4")]
	public void Destroy()
	{
	}

	[Token(Token = "0x601A72E")]
	[Address(RVA = "0x32381A8", Offset = "0x32381A8", VA = "0x32381A8")]
	public string GetPoolStatusAnalyseString()
	{
		return null;
	}
}
