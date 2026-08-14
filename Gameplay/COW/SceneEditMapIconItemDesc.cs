using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000AD3")]
public class SceneEditMapIconItemDesc : MonoBehaviour
{
	[Token(Token = "0x4005E6C")]
	[FieldOffset(Offset = "0xC")]
	public WorkshopShowMapIconData data;

	[Token(Token = "0x4005E6D")]
	[FieldOffset(Offset = "0x10")]
	public UILabel Desc;

	[Token(Token = "0x4005E6E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x6005343")]
	[Address(RVA = "0x241F540", Offset = "0x241F540", VA = "0x241F540")]
	public SceneEditMapIconItemDesc()
	{
	}

	[Token(Token = "0x6005344")]
	[Address(RVA = "0x241F548", Offset = "0x241F548", VA = "0x241F548")]
	public void SetData(WorkshopShowMapIconData _data)
	{
	}
}
