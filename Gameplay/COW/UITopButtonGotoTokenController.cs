using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B6A")]
public class UITopButtonGotoTokenController : UIBaseController, _Attribute
{
	[Token(Token = "0x40109F8")]
	[FieldOffset(Offset = "0x28")]
	private EInventory.AwardType m_TokenType;

	[Token(Token = "0x40109F9")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_TokenID;

	[Token(Token = "0x40109FA")]
	[FieldOffset(Offset = "0x30")]
	private UITopButtonGotoTokenView m_View;

	[Token(Token = "0x170012E8")]
	private bool IsReady
	{
		[Token(Token = "0x6011E31")]
		[Address(RVA = "0x2020E4C", Offset = "0x2020E4C", VA = "0x2020E4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6011E30")]
	[Address(RVA = "0x2020DC8", Offset = "0x2020DC8", VA = "0x2020DC8")]
	public UITopButtonGotoTokenController()
	{
	}

	[Token(Token = "0x6011E32")]
	[Address(RVA = "0x2020EB0", Offset = "0x2020EB0", VA = "0x2020EB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011E33")]
	[Address(RVA = "0x2020F58", Offset = "0x2020F58", VA = "0x2020F58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011E34")]
	[Address(RVA = "0x2021330", Offset = "0x2021330", VA = "0x2021330", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011E35")]
	[Address(RVA = "0x2021784", Offset = "0x2021784", VA = "0x2021784", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011E36")]
	[Address(RVA = "0x202183C", Offset = "0x202183C", VA = "0x202183C")]
	private void OnCoinsUpdate(object[] data)
	{
	}

	[Token(Token = "0x6011E37")]
	[Address(RVA = "0x202113C", Offset = "0x202113C", VA = "0x202113C")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x6011E38")]
	[Address(RVA = "0x20218A4", Offset = "0x20218A4", VA = "0x20218A4")]
	private void SetupTokenIcon(string customizedSprite, UIUtils.SpriteScaleType scaleType, bool makePixelPerfect)
	{
	}

	[Token(Token = "0x6011E39")]
	[Address(RVA = "0x202140C", Offset = "0x202140C", VA = "0x202140C")]
	private void RefreshTokenAmount()
	{
	}

	[Token(Token = "0x6011E3A")]
	[Address(RVA = "0x2021AE0", Offset = "0x2021AE0", VA = "0x2021AE0")]
	private bool IsSupportedTokenType(EInventory.AwardType tokenType)
	{
		return default(bool);
	}

	[Token(Token = "0x6011E3B")]
	[Address(RVA = "0x2021B5C", Offset = "0x2021B5C", VA = "0x2021B5C")]
	private void BindOnGotoBtnClick([Optional] Callback onGotoBtnClick)
	{
	}

	[Token(Token = "0x6011E3C")]
	[Address(RVA = "0x2021D8C", Offset = "0x2021D8C", VA = "0x2021D8C")]
	internal void SetViewData(EInventory.AwardType tokenType, uint tokenID, [Optional] Callback onGotoBtnClick, [Optional] string customizedSprite, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	[Token(Token = "0x6011E3D")]
	[Address(RVA = "0x2021F54", Offset = "0x2021F54", VA = "0x2021F54")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
