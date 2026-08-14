using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EDB")]
internal class UIDigitaluniverseBMapDoorAreaController : UIBaseController
{
	[Token(Token = "0x400C240")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBMapDoorAreaItemView m_View;

	[Token(Token = "0x400C241")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_ModelAactivity;

	[Token(Token = "0x400C242")]
	[FieldOffset(Offset = "0x30")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C243")]
	[FieldOffset(Offset = "0x0")]
	private static List<Vector3> CenterPos;

	[Token(Token = "0x400C244")]
	[FieldOffset(Offset = "0x34")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400C245")]
	[FieldOffset(Offset = "0x38")]
	private int m_Index;

	[Token(Token = "0x400C246")]
	[FieldOffset(Offset = "0x40")]
	private long m_UnlockTime;

	[Token(Token = "0x400C247")]
	[FieldOffset(Offset = "0x48")]
	private MapDoorAreaState m_State;

	[Token(Token = "0x400C248")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_StateFlag;

	[Token(Token = "0x400C249")]
	public const uint MapDoorAreaState_UnLock = 2u;

	[Token(Token = "0x400C24A")]
	public const uint MapDoorAreaState_Gift = 4u;

	[Token(Token = "0x400C24B")]
	public const uint MapDoorAreaState_Complete = 8u;

	[Token(Token = "0x400C24C")]
	public const uint MapDoorAreaState_Guide = 16u;

	[Token(Token = "0x400C24D")]
	public const uint MapDoorAreaState_Selected = 1073741824u;

	[Token(Token = "0x17000F64")]
	internal MapDoorAreaState State
	{
		[Token(Token = "0x6009653")]
		[Address(RVA = "0x2F72AAC", Offset = "0x2F72AAC", VA = "0x2F72AAC")]
		get
		{
			return default(MapDoorAreaState);
		}
		[Token(Token = "0x6009654")]
		[Address(RVA = "0x2F72B04", Offset = "0x2F72B04", VA = "0x2F72B04")]
		set
		{
		}
	}

	[Token(Token = "0x17000F65")]
	public uint StateFlag
	{
		[Token(Token = "0x6009655")]
		[Address(RVA = "0x2F72B64", Offset = "0x2F72B64", VA = "0x2F72B64")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6009656")]
		[Address(RVA = "0x2F72BBC", Offset = "0x2F72BBC", VA = "0x2F72BBC")]
		set
		{
		}
	}

	[Token(Token = "0x6009652")]
	[Address(RVA = "0x2F72A28", Offset = "0x2F72A28", VA = "0x2F72A28")]
	public UIDigitaluniverseBMapDoorAreaController()
	{
	}

	[Token(Token = "0x6009657")]
	[Address(RVA = "0x2F72C1C", Offset = "0x2F72C1C", VA = "0x2F72C1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009658")]
	[Address(RVA = "0x2F72CC4", Offset = "0x2F72CC4", VA = "0x2F72CC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009659")]
	[Address(RVA = "0x2F72E34", Offset = "0x2F72E34", VA = "0x2F72E34")]
	public void SetUIData(int index)
	{
	}

	[Token(Token = "0x600965A")]
	[Address(RVA = "0x2F73284", Offset = "0x2F73284", VA = "0x2F73284")]
	public void SetState(MapDoorAreaState state)
	{
	}

	[Token(Token = "0x600965B")]
	[Address(RVA = "0x2F73980", Offset = "0x2F73980", VA = "0x2F73980")]
	public void SetState(uint flag, bool add = true)
	{
	}

	[Token(Token = "0x600965C")]
	[Address(RVA = "0x2F740A8", Offset = "0x2F740A8", VA = "0x2F740A8")]
	public void OnClaim()
	{
	}

	[Token(Token = "0x600965D")]
	[Address(RVA = "0x2F74170", Offset = "0x2F74170", VA = "0x2F74170")]
	public void OnClaimEnd()
	{
	}

	[Token(Token = "0x600965E")]
	[Address(RVA = "0x2F73A30", Offset = "0x2F73A30", VA = "0x2F73A30")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600965F")]
	[Address(RVA = "0x2F74200", Offset = "0x2F74200", VA = "0x2F74200")]
	public bool CheckUnLock(long startTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6009661")]
	[Address(RVA = "0x2F74B00", Offset = "0x2F74B00", VA = "0x2F74B00")]
	private void _003CCheckUnLock_003Em__0()
	{
	}

	[Token(Token = "0x6009662")]
	[Address(RVA = "0x2F74BE8", Offset = "0x2F74BE8", VA = "0x2F74BE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
