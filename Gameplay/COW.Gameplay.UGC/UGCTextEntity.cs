using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C3C")]
public class UGCTextEntity : MonoBehaviour
{
	[Token(Token = "0x40064EF")]
	[FieldOffset(Offset = "0xC")]
	private UILabel m_label;

	[Token(Token = "0x40064F0")]
	[FieldOffset(Offset = "0x10")]
	private UGCPrettySprite3DSize m_autoSize;

	[Token(Token = "0x40064F1")]
	[FieldOffset(Offset = "0x14")]
	private PresentTextEntity m_entityComm;

	[Token(Token = "0x40064F2")]
	[FieldOffset(Offset = "0x18")]
	private string m_entityID;

	[Token(Token = "0x40064F3")]
	[FieldOffset(Offset = "0x0")]
	private static Material m_noZMaterial;

	[Token(Token = "0x40064F4")]
	[FieldOffset(Offset = "0x4")]
	private static Material m_zMaterial;

	[Token(Token = "0x6005D7B")]
	[Address(RVA = "0x258D9B8", Offset = "0x258D9B8", VA = "0x258D9B8")]
	public UGCTextEntity()
	{
	}

	[Token(Token = "0x6005D7C")]
	[Address(RVA = "0x258D9C0", Offset = "0x258D9C0", VA = "0x258D9C0")]
	public void OnColorChanged(int valueOld, int valueNew)
	{
	}

	[Token(Token = "0x6005D7D")]
	[Address(RVA = "0x258DA9C", Offset = "0x258DA9C", VA = "0x258DA9C")]
	public void OnScaleChanged(float valueOld, float valueNew)
	{
	}

	[Token(Token = "0x6005D7E")]
	[Address(RVA = "0x258DB34", Offset = "0x258DB34", VA = "0x258DB34")]
	public void OnOffsetChanged(Vector3 valueOld, Vector3 valueNew)
	{
	}

	[Token(Token = "0x6005D7F")]
	[Address(RVA = "0x258DC28", Offset = "0x258DC28", VA = "0x258DC28")]
	public Material GetNoZMaterial()
	{
		return null;
	}

	[Token(Token = "0x6005D80")]
	[Address(RVA = "0x258DE3C", Offset = "0x258DE3C", VA = "0x258DE3C")]
	public void OnIgnoreDepthChanged(bool valueOld, bool valueNew)
	{
	}

	[Token(Token = "0x6005D81")]
	[Address(RVA = "0x258DF4C", Offset = "0x258DF4C", VA = "0x258DF4C")]
	public void OnTextKeyChanged(string valueOld, string valueNew)
	{
	}

	[Token(Token = "0x6005D82")]
	[Address(RVA = "0x258E0C0", Offset = "0x258E0C0", VA = "0x258E0C0")]
	public void OnFollowTargetChanged(string valueOld, string valueNew)
	{
	}

	[Token(Token = "0x6005D83")]
	[Address(RVA = "0x258E160", Offset = "0x258E160", VA = "0x258E160")]
	public static UGCTextEntity Create(UIPanel iconPanel, string entityID)
	{
		return null;
	}

	[Token(Token = "0x6005D84")]
	[Address(RVA = "0x258ECB4", Offset = "0x258ECB4", VA = "0x258ECB4")]
	private void OnDestroy()
	{
	}
}
