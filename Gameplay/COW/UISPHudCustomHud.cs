using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B32")]
public class UISPHudCustomHud : MonoBehaviour
{
	[Token(Token = "0x4010930")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string FolderName;

	[Token(Token = "0x4010931")]
	[FieldOffset(Offset = "0xC")]
	public string CustomPictureName;

	[Token(Token = "0x6011C73")]
	[Address(RVA = "0x1D1C064", Offset = "0x1D1C064", VA = "0x1D1C064")]
	public UISPHudCustomHud()
	{
	}

	[Token(Token = "0x6011C74")]
	[Address(RVA = "0x1D1C104", Offset = "0x1D1C104", VA = "0x1D1C104")]
	private void Start()
	{
	}

	[Token(Token = "0x6011C75")]
	[Address(RVA = "0x1D1C250", Offset = "0x1D1C250", VA = "0x1D1C250")]
	private void SPCustomHUD(UISprite old, string picName)
	{
	}
}
