using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A3F")]
public class PreviewStoryCgMeshEffect : MonoBehaviour
{
	[Token(Token = "0x4005B6D")]
	[FieldOffset(Offset = "0xC")]
	public float DisableTime;

	[Token(Token = "0x4005B6E")]
	[FieldOffset(Offset = "0x10")]
	private float m_StartTime;

	[Token(Token = "0x4005B6F")]
	[FieldOffset(Offset = "0x14")]
	private bool m_enabled;

	[Token(Token = "0x6004FB9")]
	[Address(RVA = "0x196158C", Offset = "0x196158C", VA = "0x196158C")]
	public PreviewStoryCgMeshEffect()
	{
	}

	[Token(Token = "0x6004FBA")]
	[Address(RVA = "0x196159C", Offset = "0x196159C", VA = "0x196159C")]
	private void Start()
	{
	}

	[Token(Token = "0x6004FBB")]
	[Address(RVA = "0x19615FC", Offset = "0x19615FC", VA = "0x19615FC")]
	public void Prepare()
	{
	}

	[Token(Token = "0x6004FBC")]
	[Address(RVA = "0x196166C", Offset = "0x196166C", VA = "0x196166C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6004FBD")]
	[Address(RVA = "0x1961048", Offset = "0x1961048", VA = "0x1961048")]
	public void SetEnabled(bool _enabled)
	{
	}

	[Token(Token = "0x6004FBE")]
	[Address(RVA = "0x19616CC", Offset = "0x19616CC", VA = "0x19616CC")]
	private void Update()
	{
	}
}
