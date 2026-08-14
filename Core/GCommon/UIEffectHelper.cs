using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004143")]
internal class UIEffectHelper : MonoBehaviour
{
	[Token(Token = "0x401B648")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Effect;

	[Token(Token = "0x401B649")]
	[FieldOffset(Offset = "0x10")]
	private ResourceID EffectResID;

	[Token(Token = "0x401B64A")]
	[FieldOffset(Offset = "0x14")]
	private UIWidget BundleWidget;

	[Token(Token = "0x601AABB")]
	[Address(RVA = "0x2CA25B0", Offset = "0x2CA25B0", VA = "0x2CA25B0")]
	public UIEffectHelper()
	{
	}

	[Token(Token = "0x601AABC")]
	[Address(RVA = "0x2CA2650", Offset = "0x2CA2650", VA = "0x2CA2650")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AABD")]
	[Address(RVA = "0x2CA26B8", Offset = "0x2CA26B8", VA = "0x2CA26B8")]
	public void SetEffect(ResourceID effectResID)
	{
	}

	[Token(Token = "0x601AABE")]
	[Address(RVA = "0x2CA27AC", Offset = "0x2CA27AC", VA = "0x2CA27AC")]
	public void SetEffect(GameObject effect)
	{
	}

	[Token(Token = "0x601AABF")]
	[Address(RVA = "0x2CA2A9C", Offset = "0x2CA2A9C", VA = "0x2CA2A9C")]
	public void RemoveEffect()
	{
	}
}
