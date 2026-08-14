using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002623")]
public class UIFriendRelationshipGraphContainer : MonoBehaviour
{
	[Token(Token = "0x400EB85")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 HeadIconSize;

	[Token(Token = "0x400EB86")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 HeadBGSize;

	[Token(Token = "0x400EB87")]
	[FieldOffset(Offset = "0x1C")]
	public int NameFontSize;

	[Token(Token = "0x400EB88")]
	[FieldOffset(Offset = "0x20")]
	public Color NameFontColor;

	[Token(Token = "0x400EB89")]
	[FieldOffset(Offset = "0x30")]
	public Color ArrowColor;

	[Token(Token = "0x400EB8A")]
	[FieldOffset(Offset = "0x40")]
	public EUIFriendRelationshipType RelationshipType;

	[Token(Token = "0x600E231")]
	[Address(RVA = "0x25067B8", Offset = "0x25067B8", VA = "0x25067B8")]
	public UIFriendRelationshipGraphContainer()
	{
	}
}
