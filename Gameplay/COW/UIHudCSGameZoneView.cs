using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AA1")]
public class UIHudCSGameZoneView : MonoBehaviour
{
	[Token(Token = "0x4018EF5")]
	[FieldOffset(Offset = "0xC")]
	public UISprite Zone;

	[Token(Token = "0x4018EF6")]
	[FieldOffset(Offset = "0x10")]
	private uint m_ZoneIndex;

	[Token(Token = "0x60173A3")]
	[Address(RVA = "0x1F08DD8", Offset = "0x1F08DD8", VA = "0x1F08DD8")]
	public UIHudCSGameZoneView()
	{
	}

	[Token(Token = "0x60173A4")]
	[Address(RVA = "0x1F08DE0", Offset = "0x1F08DE0", VA = "0x1F08DE0")]
	public void Init(uint zoneIdx)
	{
	}

	[Token(Token = "0x60173A5")]
	[Address(RVA = "0x1F08F14", Offset = "0x1F08F14", VA = "0x1F08F14")]
	private void OnZoneChanged(object[] data)
	{
	}
}
