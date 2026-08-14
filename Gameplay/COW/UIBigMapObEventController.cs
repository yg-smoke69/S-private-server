using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024FD")]
public class UIBigMapObEventController : UIBaseController
{
	[Token(Token = "0x400E5AE")]
	[FieldOffset(Offset = "0x28")]
	private UIBigMapObEventView m_View;

	[Token(Token = "0x400E5AF")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_Scale;

	[Token(Token = "0x400E5B0")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 targetPosOffset;

	[Token(Token = "0x600D60E")]
	[Address(RVA = "0x10D0B98", Offset = "0x10D0B98", VA = "0x10D0B98")]
	public UIBigMapObEventController()
	{
	}

	[Token(Token = "0x600D60F")]
	[Address(RVA = "0x10D0C1C", Offset = "0x10D0C1C", VA = "0x10D0C1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D610")]
	[Address(RVA = "0x10D0CC0", Offset = "0x10D0CC0", VA = "0x10D0CC0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D611")]
	[Address(RVA = "0x10D1010", Offset = "0x10D1010", VA = "0x10D1010")]
	public void OnDragStart()
	{
	}

	[Token(Token = "0x600D612")]
	[Address(RVA = "0x10D10A0", Offset = "0x10D10A0", VA = "0x10D10A0")]
	public void OnDragRelase()
	{
	}

	[Token(Token = "0x600D613")]
	[Address(RVA = "0x10D1130", Offset = "0x10D1130", VA = "0x10D1130")]
	public bool IsEventIcon(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x600D614")]
	[Address(RVA = "0x10D1240", Offset = "0x10D1240", VA = "0x10D1240")]
	public void UpdateScale(float scale)
	{
	}

	[Token(Token = "0x600D615")]
	[Address(RVA = "0x10D13AC", Offset = "0x10D13AC", VA = "0x10D13AC")]
	public float GetMoveScale()
	{
		return default(float);
	}

	[Token(Token = "0x600D616")]
	[Address(RVA = "0x10D1404", Offset = "0x10D1404", VA = "0x10D1404")]
	private void OnConfirm()
	{
	}

	[Token(Token = "0x600D617")]
	[Address(RVA = "0x10D1A24", Offset = "0x10D1A24", VA = "0x10D1A24")]
	public void InitMoveScale(Vector3 scale)
	{
	}

	[Token(Token = "0x600D618")]
	[Address(RVA = "0x10D1AAC", Offset = "0x10D1AAC", VA = "0x10D1AAC")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x600D619")]
	[Address(RVA = "0x10D1CA0", Offset = "0x10D1CA0", VA = "0x10D1CA0")]
	private void OnEventSelect(object[] data)
	{
	}

	[Token(Token = "0x600D61A")]
	[Address(RVA = "0x10D196C", Offset = "0x10D196C", VA = "0x10D196C")]
	private void ShowEventIcon(bool show)
	{
	}

	[Token(Token = "0x600D61B")]
	[Address(RVA = "0x10D1E4C", Offset = "0x10D1E4C", VA = "0x10D1E4C")]
	private void OnBigMapDisabled(object[] data)
	{
	}

	[Token(Token = "0x600D61C")]
	[Address(RVA = "0x10D20F4", Offset = "0x10D20F4", VA = "0x10D20F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
