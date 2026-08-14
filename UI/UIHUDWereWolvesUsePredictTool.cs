using COW;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002C49")]
public class UIHUDWereWolvesUsePredictTool : UIBaseController
{
	[Token(Token = "0x4010E3D")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWereWolvesUsePredictView m_View;

	[Token(Token = "0x4010E3E")]
	[FieldOffset(Offset = "0x30")]
	private IHAAMHPPLMG m_TargetID;

	[Token(Token = "0x60127A5")]
	[Address(RVA = "0x1484424", Offset = "0x1484424", VA = "0x1484424")]
	public UIHUDWereWolvesUsePredictTool()
	{
	}

	[Token(Token = "0x60127A6")]
	[Address(RVA = "0x1484500", Offset = "0x1484500", VA = "0x1484500")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60127A7")]
	[Address(RVA = "0x1484568", Offset = "0x1484568", VA = "0x1484568", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60127A8")]
	[Address(RVA = "0x148467C", Offset = "0x148467C", VA = "0x148467C")]
	private void UsePredictTool()
	{
	}

	[Token(Token = "0x60127A9")]
	[Address(RVA = "0x1484D7C", Offset = "0x1484D7C", VA = "0x1484D7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60127AA")]
	[Address(RVA = "0x1485114", Offset = "0x1485114", VA = "0x1485114")]
	private void OnActionEnable(bool isEnable)
	{
	}

	[Token(Token = "0x60127AB")]
	[Address(RVA = "0x1484D80", Offset = "0x1484D80", VA = "0x1484D80")]
	private void UpdateValid()
	{
	}

	[Token(Token = "0x60127AC")]
	[Address(RVA = "0x148515C", Offset = "0x148515C", VA = "0x148515C")]
	private void ChooseNewTarget()
	{
	}

	[Token(Token = "0x60127AD")]
	[Address(RVA = "0x1484A60", Offset = "0x1484A60", VA = "0x1484A60")]
	private bool IsPlayerValidTarget(Player player)
	{
		return default(bool);
	}

	[Token(Token = "0x60127AE")]
	[Address(RVA = "0x148554C", Offset = "0x148554C", VA = "0x148554C")]
	private bool CheckInPredictRange(Vector3 targetPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60127AF")]
	[Address(RVA = "0x1484BE0", Offset = "0x1484BE0", VA = "0x1484BE0")]
	private void PlayPredictEffect(Vector3 targetPos)
	{
	}
}
