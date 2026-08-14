using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AA0")]
public class UIHudBombZoneView : MonoBehaviour
{
	[Token(Token = "0x4018EF2")]
	[FieldOffset(Offset = "0xC")]
	public UISprite Zone;

	[Token(Token = "0x4018EF3")]
	[FieldOffset(Offset = "0x10")]
	private uint m_ZoneIndex;

	[Token(Token = "0x4018EF4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Label;

	[Token(Token = "0x60173A1")]
	[Address(RVA = "0x1E15624", Offset = "0x1E15624", VA = "0x1E15624")]
	public UIHudBombZoneView()
	{
	}

	[Token(Token = "0x60173A2")]
	[Address(RVA = "0x1E1562C", Offset = "0x1E1562C", VA = "0x1E1562C")]
	public void SetUIData(uint zoneIdx, float scale, bool isMiniMap = false)
	{
	}
}
