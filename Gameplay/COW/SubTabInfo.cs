using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021DE")]
public class SubTabInfo
{
	[Token(Token = "0x400D3D2")]
	[FieldOffset(Offset = "0x8")]
	public uint TabType;

	[Token(Token = "0x400D3D3")]
	[FieldOffset(Offset = "0xC")]
	public string SpriteName;

	[Token(Token = "0x400D3D4")]
	[FieldOffset(Offset = "0x10")]
	public UIToggleButton ToggleButton;

	[Token(Token = "0x600B5AD")]
	[Address(RVA = "0x288FF8C", Offset = "0x288FF8C", VA = "0x288FF8C")]
	public SubTabInfo(UIModelAvatarBase.EWardrobeType wardrobetype, string sprite_name)
	{
	}

	[Token(Token = "0x600B5AE")]
	[Address(RVA = "0x288FFB4", Offset = "0x288FFB4", VA = "0x288FFB4")]
	public SubTabInfo(CSSharedItemDataManager.CollectionSubType collectionType, string sprite_name)
	{
	}

	[Token(Token = "0x600B5AF")]
	[Address(RVA = "0x288FFDC", Offset = "0x288FFDC", VA = "0x288FFDC")]
	public SubTabInfo(CSSharedItemDataManager.CharacterSubType characterType, string sprite_name)
	{
	}

	[Token(Token = "0x600B5B0")]
	[Address(RVA = "0x2890004", Offset = "0x2890004", VA = "0x2890004")]
	public SubTabInfo(CSSharedItemDataManager.PetSubType itemType, string sprite_name)
	{
	}
}
