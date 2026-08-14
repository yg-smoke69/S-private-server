using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000BE0")]
public class UIHudBlockEditCustomFuncItemController : MonoBehaviour
{
	[Token(Token = "0x40062EC")]
	[FieldOffset(Offset = "0xC")]
	public UIButton BtnDel;

	[Token(Token = "0x40062ED")]
	[FieldOffset(Offset = "0x10")]
	public bool IsParam;

	[Token(Token = "0x40062EE")]
	[FieldOffset(Offset = "0x14")]
	public UIInput InputField;

	[Token(Token = "0x40062EF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NameLabel;

	[Token(Token = "0x6005A06")]
	[Address(RVA = "0x1E03808", Offset = "0x1E03808", VA = "0x1E03808")]
	public UIHudBlockEditCustomFuncItemController()
	{
	}

	[Token(Token = "0x6005A07")]
	[Address(RVA = "0x1E03810", Offset = "0x1E03810", VA = "0x1E03810")]
	public void ShowDelBtn(bool b)
	{
	}
}
