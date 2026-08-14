using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E3C")]
public class AkSurfaceReflector : MonoBehaviour
{
	[Token(Token = "0x401A57D")]
	[FieldOffset(Offset = "0xC")]
	public AcousticTexture AcousticTexture;

	[Token(Token = "0x401A57E")]
	[FieldOffset(Offset = "0x10")]
	public bool EnableDiffraction;

	[Token(Token = "0x401A57F")]
	[FieldOffset(Offset = "0x11")]
	public bool EnableDiffractionOnBoundaryEdges;

	[Token(Token = "0x401A580")]
	[FieldOffset(Offset = "0x14")]
	public AkRoom AssociatedRoom;

	[Token(Token = "0x401A581")]
	[FieldOffset(Offset = "0x18")]
	private MeshFilter MeshFilter;

	[Token(Token = "0x60194D3")]
	[Address(RVA = "0x2EB8DD4", Offset = "0x2EB8DD4", VA = "0x2EB8DD4")]
	public AkSurfaceReflector()
	{
	}

	[Token(Token = "0x60194D4")]
	[Address(RVA = "0x2EB8E50", Offset = "0x2EB8E50", VA = "0x2EB8E50")]
	public static ulong GetAkGeometrySetID(MeshFilter meshFilter)
	{
		return default(ulong);
	}

	[Token(Token = "0x60194D5")]
	[Address(RVA = "0x2EB8E80", Offset = "0x2EB8E80", VA = "0x2EB8E80")]
	public static void AddGeometrySet(AcousticTexture acousticTexture, MeshFilter meshFilter, ulong roomID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges)
	{
	}

	[Token(Token = "0x60194D6")]
	[Address(RVA = "0x2EBA440", Offset = "0x2EBA440", VA = "0x2EBA440")]
	public static void RemoveGeometrySet(MeshFilter meshFilter)
	{
	}

	[Token(Token = "0x60194D7")]
	[Address(RVA = "0x2EBA51C", Offset = "0x2EBA51C", VA = "0x2EBA51C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60194D8")]
	[Address(RVA = "0x2EBA584", Offset = "0x2EBA584", VA = "0x2EBA584")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60194D9")]
	[Address(RVA = "0x2EBA6AC", Offset = "0x2EBA6AC", VA = "0x2EBA6AC")]
	private void OnDisable()
	{
	}
}
