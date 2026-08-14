using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027C9")]
public class UIHudNameBattleFlagController : UIHudNameBaseController
{
	[Token(Token = "0x400F5A8")]
	[FieldOffset(Offset = "0x50")]
	private LevelBattleFlag bindedLevelObject;

	[Token(Token = "0x400F5A9")]
	[FieldOffset(Offset = "0x54")]
	private UIHudNameBattleFlagView m_View;

	[Token(Token = "0x600F63A")]
	[Address(RVA = "0x1F4FE50", Offset = "0x1F4FE50", VA = "0x1F4FE50")]
	public UIHudNameBattleFlagController()
	{
	}

	[Token(Token = "0x600F63B")]
	[Address(RVA = "0x1F4FE54", Offset = "0x1F4FE54", VA = "0x1F4FE54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F63C")]
	[Address(RVA = "0x1F4FEFC", Offset = "0x1F4FEFC", VA = "0x1F4FEFC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F63D")]
	[Address(RVA = "0x1F4FFB4", Offset = "0x1F4FFB4", VA = "0x1F4FFB4")]
	public void BindLevelObject(LevelBattleFlag battle_flag)
	{
	}

	[Token(Token = "0x600F63E")]
	[Address(RVA = "0x1F500F4", Offset = "0x1F500F4", VA = "0x1F500F4")]
	public void ClearBind()
	{
	}

	[Token(Token = "0x600F63F")]
	[Address(RVA = "0x1F5020C", Offset = "0x1F5020C", VA = "0x1F5020C", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F640")]
	[Address(RVA = "0x1F503FC", Offset = "0x1F503FC", VA = "0x1F503FC", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F641")]
	[Address(RVA = "0x1F50454", Offset = "0x1F50454", VA = "0x1F50454", Slot = "44")]
	protected override bool IsVisibleWithZoneType(int zonetype)
	{
		return default(bool);
	}

	[Token(Token = "0x600F642")]
	[Address(RVA = "0x1F504C4", Offset = "0x1F504C4", VA = "0x1F504C4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F643")]
	[Address(RVA = "0x1F504C8", Offset = "0x1F504C8", VA = "0x1F504C8")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F644")]
	[Address(RVA = "0x1F504D8", Offset = "0x1F504D8", VA = "0x1F504D8")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F645")]
	[Address(RVA = "0x1F504DC", Offset = "0x1F504DC", VA = "0x1F504DC")]
	public bool _003C_003EiFixBaseProxy_IsVisibleWithZoneType(int P0)
	{
		return default(bool);
	}
}
