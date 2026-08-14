using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040FA")]
public class ReusableObject : MonoBehaviour
{
	[Token(Token = "0x401B4E0")]
	[FieldOffset(Offset = "0xC")]
	private ResourceID _ResID;

	[Token(Token = "0x401B4E1")]
	[FieldOffset(Offset = "0x10")]
	private IReusableObjectOwner _003COwnerEntity_003Ek__BackingField;

	[Token(Token = "0x401B4E2")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsInPool;

	[Token(Token = "0x17001D0F")]
	public ResourceID ResID
	{
		[Token(Token = "0x601A84E")]
		[Address(RVA = "0x3230288", Offset = "0x3230288", VA = "0x3230288")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x601A84F")]
		[Address(RVA = "0x3230290", Offset = "0x3230290", VA = "0x3230290")]
		set
		{
		}
	}

	[Token(Token = "0x17001D10")]
	public IReusableObjectOwner OwnerEntity
	{
		[Token(Token = "0x601A850")]
		[Address(RVA = "0x3230298", Offset = "0x3230298", VA = "0x3230298")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A851")]
		[Address(RVA = "0x32302A0", Offset = "0x32302A0", VA = "0x32302A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D11")]
	public bool IsInPool
	{
		[Token(Token = "0x601A852")]
		[Address(RVA = "0x32302A8", Offset = "0x32302A8", VA = "0x32302A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601A84D")]
	[Address(RVA = "0x32301E8", Offset = "0x32301E8", VA = "0x32301E8")]
	public ReusableObject()
	{
	}

	[Token(Token = "0x601A853")]
	[Address(RVA = "0x32302B0", Offset = "0x32302B0", VA = "0x32302B0", Slot = "4")]
	public virtual void Prepare()
	{
	}

	[Token(Token = "0x601A854")]
	[Address(RVA = "0x32302BC", Offset = "0x32302BC", VA = "0x32302BC")]
	public void Recycle(float delayTime = 0f)
	{
	}

	[Token(Token = "0x601A855")]
	[Address(RVA = "0x3230398", Offset = "0x3230398", VA = "0x3230398")]
	public void TemporyStopUsing()
	{
	}

	[Token(Token = "0x601A856")]
	[Address(RVA = "0x3230498", Offset = "0x3230498", VA = "0x3230498", Slot = "5")]
	protected virtual void DoRecycle()
	{
	}
}
