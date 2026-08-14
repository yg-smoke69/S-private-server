using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026C6")]
public class UIHeroicMarkItemCtrl : MonoBehaviour
{
	[Token(Token = "0x400EF47")]
	[FieldOffset(Offset = "0xC")]
	public UISprite Icon;

	[Token(Token = "0x400EF48")]
	[FieldOffset(Offset = "0x10")]
	public UILabel Desc;

	[Token(Token = "0x400EF49")]
	[FieldOffset(Offset = "0x14")]
	public GameObject DefaultLabel;

	[Token(Token = "0x400EF4A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject VfxContainer;

	[Token(Token = "0x400EF4B")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject m_CacheEffGo;

	[Token(Token = "0x600EA51")]
	[Address(RVA = "0x162CAD0", Offset = "0x162CAD0", VA = "0x162CAD0")]
	public UIHeroicMarkItemCtrl()
	{
	}

	[Token(Token = "0x600EA52")]
	[Address(RVA = "0x162BACC", Offset = "0x162BACC", VA = "0x162BACC")]
	public void SetData(uint season, ResourceID iconRes, ResourceID vfxRes, bool isDefault)
	{
	}

	[Token(Token = "0x600EA53")]
	[Address(RVA = "0x162BE58", Offset = "0x162BE58", VA = "0x162BE58")]
	public void ClearEffect()
	{
	}
}
