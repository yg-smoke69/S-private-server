using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CE1")]
public class UMAMaterial : ScriptableObject
{
	[Token(Token = "0x2003CE2")]
	public enum MaterialType
	{
		[Token(Token = "0x4019DD2")]
		Atlas = 1,
		[Token(Token = "0x4019DD3")]
		NoAtlas
	}

	[Token(Token = "0x2003CE3")]
	public enum ChannelType
	{
		[Token(Token = "0x4019DD5")]
		Texture,
		[Token(Token = "0x4019DD6")]
		NormalMap,
		[Token(Token = "0x4019DD7")]
		MaterialColor,
		[Token(Token = "0x4019DD8")]
		TintedTexture,
		[Token(Token = "0x4019DD9")]
		DiffuseTexture
	}

	[Serializable]
	[Token(Token = "0x2003CE4")]
	public class MaterialChannel
	{
		[Token(Token = "0x4019DDA")]
		[FieldOffset(Offset = "0x8")]
		public ChannelType channelType;

		[Token(Token = "0x4019DDB")]
		[FieldOffset(Offset = "0xC")]
		public RenderTextureFormat textureFormat;

		[Token(Token = "0x4019DDC")]
		[FieldOffset(Offset = "0x10")]
		public string materialPropertyName;

		[NonSerialized]
		[Token(Token = "0x4019DDD")]
		[FieldOffset(Offset = "0x14")]
		private int _materialPropertyID;

		[Token(Token = "0x170019BC")]
		public int materialPropertyID
		{
			[Token(Token = "0x60185F7")]
			[Address(RVA = "0x35DFCCC", Offset = "0x35DFCCC", VA = "0x35DFCCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60185F6")]
		[Address(RVA = "0x35DFCF8", Offset = "0x35DFCF8", VA = "0x35DFCF8")]
		public MaterialChannel()
		{
		}
	}

	[Token(Token = "0x4019DCC")]
	[FieldOffset(Offset = "0xC")]
	public Material material;

	[Token(Token = "0x4019DCD")]
	[FieldOffset(Offset = "0x10")]
	public MaterialType materialType;

	[Token(Token = "0x4019DCE")]
	[FieldOffset(Offset = "0x14")]
	public bool useSkin;

	[Token(Token = "0x4019DCF")]
	[FieldOffset(Offset = "0x18")]
	public MaterialChannel[] channels;

	[NonSerialized]
	[Token(Token = "0x4019DD0")]
	[FieldOffset(Offset = "0x1C")]
	private bool validated;

	[Token(Token = "0x60185F2")]
	[Address(RVA = "0x35DF8E0", Offset = "0x35DF8E0", VA = "0x35DF8E0")]
	public UMAMaterial()
	{
	}

	[Token(Token = "0x60185F3")]
	[Address(RVA = "0x35DCE0C", Offset = "0x35DCE0C", VA = "0x35DCE0C")]
	public bool Equals(UMAMaterial material)
	{
		return default(bool);
	}

	[Token(Token = "0x60185F4")]
	[Address(RVA = "0x35DF8F0", Offset = "0x35DF8F0", VA = "0x35DF8F0")]
	public bool ValidateChannels()
	{
		return default(bool);
	}

	[Token(Token = "0x60185F5")]
	[Address(RVA = "0x35DF91C", Offset = "0x35DF91C", VA = "0x35DF91C")]
	private bool DoValidateChannels()
	{
		return default(bool);
	}
}
