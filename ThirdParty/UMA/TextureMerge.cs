using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CBD")]
public class TextureMerge : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003CBE")]
	public class TextureMergeRect
	{
		[Token(Token = "0x4019CC5")]
		[FieldOffset(Offset = "0x8")]
		public Material mat;

		[Token(Token = "0x4019CC6")]
		[FieldOffset(Offset = "0xC")]
		public Texture tex;

		[Token(Token = "0x4019CC7")]
		[FieldOffset(Offset = "0x10")]
		public Rect rect;

		[Token(Token = "0x4019CC8")]
		[FieldOffset(Offset = "0x20")]
		public Rect srcRect;

		[Token(Token = "0x60184EC")]
		[Address(RVA = "0x2DF1AA8", Offset = "0x2DF1AA8", VA = "0x2DF1AA8")]
		public TextureMergeRect()
		{
		}
	}

	[Token(Token = "0x4019CB0")]
	[FieldOffset(Offset = "0xC")]
	public Camera myCamera;

	[Token(Token = "0x4019CB1")]
	[FieldOffset(Offset = "0x10")]
	public Material material;

	[Token(Token = "0x4019CB2")]
	[FieldOffset(Offset = "0x14")]
	public Shader normalShader;

	[Token(Token = "0x4019CB3")]
	[FieldOffset(Offset = "0x18")]
	public Shader diffuseShader;

	[Token(Token = "0x4019CB4")]
	[FieldOffset(Offset = "0x1C")]
	public Shader dataShader;

	[Token(Token = "0x4019CB5")]
	[FieldOffset(Offset = "0x20")]
	public Shader cutoutShader;

	[Token(Token = "0x4019CB6")]
	[FieldOffset(Offset = "0x24")]
	public Shader skinShader;

	[Token(Token = "0x4019CB7")]
	[FieldOffset(Offset = "0x28")]
	public Shader blendShader;

	[Token(Token = "0x4019CB8")]
	[FieldOffset(Offset = "0x2C")]
	public int textureMergeRectCount;

	[Token(Token = "0x4019CB9")]
	[FieldOffset(Offset = "0x30")]
	public TextureMergeRect[] textureMergeRects;

	[Token(Token = "0x4019CBA")]
	[FieldOffset(Offset = "0x34")]
	private int _MainTex;

	[Token(Token = "0x4019CBB")]
	[FieldOffset(Offset = "0x38")]
	private int _ExtraTex;

	[Token(Token = "0x4019CBC")]
	[FieldOffset(Offset = "0x3C")]
	private int _Color;

	[Token(Token = "0x4019CBD")]
	[FieldOffset(Offset = "0x40")]
	private int _AdditiveColor;

	[Token(Token = "0x4019CBE")]
	[FieldOffset(Offset = "0x44")]
	private int _AlphaTex;

	[Token(Token = "0x4019CBF")]
	[FieldOffset(Offset = "0x48")]
	private int _BiasScale;

	[Token(Token = "0x4019CC0")]
	[FieldOffset(Offset = "0x4C")]
	private int _RegionCoord;

	[Token(Token = "0x4019CC1")]
	[FieldOffset(Offset = "0x50")]
	private int _ClipFlag;

	[Token(Token = "0x4019CC2")]
	[FieldOffset(Offset = "0x54")]
	private int _DestBlend;

	[Token(Token = "0x4019CC3")]
	[FieldOffset(Offset = "0x58")]
	private Rect atlasRect;

	[Token(Token = "0x4019CC4")]
	[FieldOffset(Offset = "0x68")]
	private int height;

	[Token(Token = "0x60184DF")]
	[Address(RVA = "0x2DF0AC8", Offset = "0x2DF0AC8", VA = "0x2DF0AC8")]
	public TextureMerge()
	{
	}

	[Token(Token = "0x60184E0")]
	[Address(RVA = "0x2DF0AD0", Offset = "0x2DF0AD0", VA = "0x2DF0AD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60184E1")]
	[Address(RVA = "0x2DF0C18", Offset = "0x2DF0C18", VA = "0x2DF0C18")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x60184E2")]
	[Address(RVA = "0x2DF0D28", Offset = "0x2DF0D28", VA = "0x2DF0D28")]
	private void DrawRect(ref TextureMergeRect textureMergeRect)
	{
	}

	[Token(Token = "0x60184E3")]
	[Address(RVA = "0x2DF0F90", Offset = "0x2DF0F90", VA = "0x2DF0F90")]
	public void BlitTexture(ref RenderTexture renderTexture, float normalSpecTexScale)
	{
	}

	[Token(Token = "0x60184E4")]
	[Address(RVA = "0x2DF1628", Offset = "0x2DF1628", VA = "0x2DF1628")]
	public Vector4 SetBiasScale(Rect rect, int rtWidth, int rtHeight, Rect srcRect)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector4);
	}

	[Token(Token = "0x60184E5")]
	[Address(RVA = "0x2DF1800", Offset = "0x2DF1800", VA = "0x2DF1800")]
	public void Reset()
	{
	}

	[Token(Token = "0x60184E6")]
	[Address(RVA = "0x2DF180C", Offset = "0x2DF180C", VA = "0x2DF180C")]
	internal void EnsureCapacity(int moduleCount)
	{
	}

	[Token(Token = "0x60184E7")]
	[Address(RVA = "0x2DF1AB0", Offset = "0x2DF1AB0", VA = "0x2DF1AB0")]
	private void SetupMaterial(ref TextureMergeRect textureMergeRect, UMAData.MaterialFragment source, int textureType)
	{
	}

	[Token(Token = "0x60184E8")]
	[Address(RVA = "0x2DF223C", Offset = "0x2DF223C", VA = "0x2DF223C")]
	public void SetupModule(UMAData.MaterialFragment source, int textureType)
	{
	}

	[Token(Token = "0x60184E9")]
	[Address(RVA = "0x2DF24BC", Offset = "0x2DF24BC", VA = "0x2DF24BC")]
	public void SetupModule(UMAData.GeneratedMaterial atlas, int idx, int textureType)
	{
	}

	[Token(Token = "0x60184EA")]
	[Address(RVA = "0x2DF2614", Offset = "0x2DF2614", VA = "0x2DF2614")]
	private void SetupOverlay(UMAData.MaterialFragment source, int i2, int textureType)
	{
	}

	[Token(Token = "0x60184EB")]
	[Address(RVA = "0x2DF2A78", Offset = "0x2DF2A78", VA = "0x2DF2A78")]
	private bool SetupMaterial(ref TextureMergeRect textureMergeRect, UMAData.MaterialFragment source, int i2, Rect overlayRect, int textureType)
	{
		return default(bool);
	}
}
