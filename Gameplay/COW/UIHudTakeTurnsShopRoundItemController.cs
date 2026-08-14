using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x20020F0")]
public class UIHudTakeTurnsShopRoundItemController : UIBaseController
{
	[Token(Token = "0x20020F1")]
	public enum ERoundType
	{
		[Token(Token = "0x400CDF4")]
		Self,
		[Token(Token = "0x400CDF5")]
		Opponent,
		[Token(Token = "0x400CDF6")]
		Final
	}

	[Token(Token = "0x400CDF2")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTakeTurnsShopRoundItemView m_View;

	[Token(Token = "0x600AAB0")]
	[Address(RVA = "0x17908F8", Offset = "0x17908F8", VA = "0x17908F8")]
	public UIHudTakeTurnsShopRoundItemController()
	{
	}

	[Token(Token = "0x600AAB1")]
	[Address(RVA = "0x179097C", Offset = "0x179097C", VA = "0x179097C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AAB2")]
	[Address(RVA = "0x1790A24", Offset = "0x1790A24", VA = "0x1790A24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AAB3")]
	[Address(RVA = "0x1790AE0", Offset = "0x1790AE0", VA = "0x1790AE0")]
	public void SetView(ERoundType roundType, int curRound, HNLNFDIECBD roundState)
	{
	}

	[Token(Token = "0x600AAB4")]
	[Address(RVA = "0x1790D60", Offset = "0x1790D60", VA = "0x1790D60")]
	public void PlayScaleAnim(bool enlarge)
	{
	}

	[Token(Token = "0x600AAB5")]
	[Address(RVA = "0x1790F88", Offset = "0x1790F88", VA = "0x1790F88")]
	public void SetScale(bool enlarge)
	{
	}

	[Token(Token = "0x600AAB6")]
	[Address(RVA = "0x1791140", Offset = "0x1791140", VA = "0x1791140")]
	private void _003CPlayScaleAnim_003Em__0()
	{
	}

	[Token(Token = "0x600AAB7")]
	[Address(RVA = "0x1791184", Offset = "0x1791184", VA = "0x1791184")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
