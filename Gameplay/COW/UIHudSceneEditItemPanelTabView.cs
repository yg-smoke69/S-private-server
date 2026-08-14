using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002337")]
internal class UIHudSceneEditItemPanelTabView : MonoBehaviour
{
	[Token(Token = "0x400DB63")]
	[FieldOffset(Offset = "0xC")]
	public uint OptionID;

	[Token(Token = "0x400DB64")]
	[FieldOffset(Offset = "0x10")]
	public GameObject IsNewHint;

	[Token(Token = "0x400DB65")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton ToggleButton;

	[Token(Token = "0x400DB66")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SelectedLabel;

	[Token(Token = "0x400DB67")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel UnSelectedLabel;

	[Token(Token = "0x600C38D")]
	[Address(RVA = "0x24DD1A0", Offset = "0x24DD1A0", VA = "0x24DD1A0")]
	public UIHudSceneEditItemPanelTabView()
	{
	}
}
