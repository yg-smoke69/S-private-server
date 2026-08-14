using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CCF")]
public sealed class UIVariableBindImage : UIVariableBind
{
	[Token(Token = "0x2000CD0")]
	public enum EFitSizeType
	{
		[Token(Token = "0x40067FB")]
		none,
		[Token(Token = "0x40067FC")]
		nativeSize,
		[Token(Token = "0x40067FD")]
		widthHeight
	}

	[Token(Token = "0x40067EC")]
	[FieldOffset(Offset = "0x1C")]
	public List<UIAtlas> MultiUIAtlas;

	[Token(Token = "0x40067ED")]
	[FieldOffset(Offset = "0x20")]
	private string spriteBind;

	[Token(Token = "0x40067EE")]
	[FieldOffset(Offset = "0x24")]
	private string fillAmountBind;

	[Token(Token = "0x40067EF")]
	[FieldOffset(Offset = "0x28")]
	private EFitSizeType autoFitSizeType;

	[Token(Token = "0x40067F0")]
	[FieldOffset(Offset = "0x2C")]
	private int autoFitMaxWidth;

	[Token(Token = "0x40067F1")]
	[FieldOffset(Offset = "0x30")]
	private int autoFitMaxHeight;

	[Token(Token = "0x40067F2")]
	[FieldOffset(Offset = "0x34")]
	private bool autoDisable;

	[Token(Token = "0x40067F3")]
	[FieldOffset(Offset = "0x35")]
	private bool refreshImageOnInitial;

	[Token(Token = "0x40067F4")]
	[FieldOffset(Offset = "0x38")]
	private UISprite m_image;

	[Token(Token = "0x40067F5")]
	[FieldOffset(Offset = "0x3C")]
	private UITexture m_rawImage;

	[Token(Token = "0x40067F6")]
	[FieldOffset(Offset = "0x40")]
	private UINetworkTexture m_networkTexture;

	[Token(Token = "0x40067F7")]
	[FieldOffset(Offset = "0x44")]
	private UIVariable imageVariable;

	[Token(Token = "0x40067F8")]
	[FieldOffset(Offset = "0x48")]
	private UIVariable fillAmountVariable;

	[Token(Token = "0x40067F9")]
	[FieldOffset(Offset = "0x4C")]
	private UIAtlas m_defaultAtlas;

	[Token(Token = "0x6006161")]
	[Address(RVA = "0x3162498", Offset = "0x3162498", VA = "0x3162498")]
	public UIVariableBindImage()
	{
	}

	[Token(Token = "0x6006162")]
	[Address(RVA = "0x3162530", Offset = "0x3162530", VA = "0x3162530", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x6006163")]
	[Address(RVA = "0x3163514", Offset = "0x3163514", VA = "0x3163514", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x6006164")]
	[Address(RVA = "0x3162814", Offset = "0x3162814", VA = "0x3162814")]
	private void RefreshImage()
	{
	}

	[Token(Token = "0x6006165")]
	[Address(RVA = "0x3163420", Offset = "0x3163420", VA = "0x3163420")]
	private void RefreshFillAmount()
	{
	}

	[Token(Token = "0x6006166")]
	[Address(RVA = "0x31636C8", Offset = "0x31636C8", VA = "0x31636C8")]
	private void RefreshDisableStatus(UISprite img)
	{
	}

	[Token(Token = "0x6006167")]
	[Address(RVA = "0x3163818", Offset = "0x3163818", VA = "0x3163818")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6006168")]
	[Address(RVA = "0x3163904", Offset = "0x3163904", VA = "0x3163904")]
	private void OnEnable()
	{
	}
}
