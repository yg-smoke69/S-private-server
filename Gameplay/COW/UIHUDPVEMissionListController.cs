using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022BE")]
public class UIHUDPVEMissionListController : UIBaseController
{
	[Token(Token = "0x400D936")]
	private const int m_MaxItemNum = 6;

	[Token(Token = "0x400D937")]
	[FieldOffset(Offset = "0x28")]
	private float m_ItemHeight;

	[Token(Token = "0x400D938")]
	[FieldOffset(Offset = "0x2C")]
	private int m_CurTopItemIndex;

	[Token(Token = "0x400D939")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_AnimCoroutine;

	[Token(Token = "0x400D93A")]
	[FieldOffset(Offset = "0x34")]
	private Queue<UIHUDPVEMissionItemController> m_ItemControllers;

	[Token(Token = "0x400D93B")]
	[FieldOffset(Offset = "0x38")]
	private UIHUDPVEMissionListView m_View;

	[Token(Token = "0x1700109B")]
	public Transform ItemContainer
	{
		[Token(Token = "0x600BF23")]
		[Address(RVA = "0x1684594", Offset = "0x1684594", VA = "0x1684594")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BF21")]
	[Address(RVA = "0x1684434", Offset = "0x1684434", VA = "0x1684434")]
	public UIHUDPVEMissionListController()
	{
	}

	[Token(Token = "0x600BF22")]
	[Address(RVA = "0x16844EC", Offset = "0x16844EC", VA = "0x16844EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF24")]
	[Address(RVA = "0x1684620", Offset = "0x1684620", VA = "0x1684620", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF25")]
	[Address(RVA = "0x16846DC", Offset = "0x16846DC", VA = "0x16846DC")]
	public void OnMissionCome(string content, Vector3 topAnimStartLocalPos, float topAnimStartWidth)
	{
	}

	[Token(Token = "0x600BF26")]
	[Address(RVA = "0x1684B58", Offset = "0x1684B58", VA = "0x1684B58")]
	private void PlayAnim()
	{
	}

	[Token(Token = "0x600BF27")]
	[Address(RVA = "0x1684DE0", Offset = "0x1684DE0", VA = "0x1684DE0")]
	private void TopItemAnim(UIHUDPVEMissionItemController item, Vector3 targetPos)
	{
	}

	[Token(Token = "0x600BF28")]
	[Address(RVA = "0x1684F4C", Offset = "0x1684F4C", VA = "0x1684F4C")]
	private void LowItemAnim(UIHUDPVEMissionItemController item, Vector3 targetPos)
	{
	}

	[Token(Token = "0x600BF29")]
	[Address(RVA = "0x1685004", Offset = "0x1685004", VA = "0x1685004")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
