using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F8C")]
public class MipmapStreamingObj : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003F8D")]
	public class TextureInfo
	{
		[Token(Token = "0x401AC82")]
		[FieldOffset(Offset = "0x8")]
		public string m_Name;

		[Token(Token = "0x401AC83")]
		[FieldOffset(Offset = "0xC")]
		public List<string> m_ResPaths;

		[NonSerialized]
		[Token(Token = "0x401AC84")]
		[FieldOffset(Offset = "0x10")]
		public bool m_Loading;

		[NonSerialized]
		[Token(Token = "0x401AC85")]
		[FieldOffset(Offset = "0x14")]
		public int m_CurMipmapLvl;

		[NonSerialized]
		[Token(Token = "0x401AC86")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D m_Texture;

		[NonSerialized]
		[Token(Token = "0x401AC87")]
		[FieldOffset(Offset = "0x1C")]
		public string m_TexturePath;

		[Token(Token = "0x6019DD6")]
		[Address(RVA = "0x25C62C8", Offset = "0x25C62C8", VA = "0x25C62C8")]
		public TextureInfo()
		{
		}

		[Token(Token = "0x6019DD7")]
		[Address(RVA = "0x25C5D88", Offset = "0x25C5D88", VA = "0x25C5D88")]
		public int GDGBJMKIBGI(int DDDEIMFLHFG)
		{
			return default(int);
		}

		[Token(Token = "0x6019DD8")]
		[Address(RVA = "0x25C601C", Offset = "0x25C601C", VA = "0x25C601C")]
		public bool JBIHIILHDMF(string AOBALOEMGMJ)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401AC7B")]
	[FieldOffset(Offset = "0xC")]
	public List<TextureInfo> m_TextureInfos;

	[Token(Token = "0x401AC7C")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 m_TextureScale;

	[Token(Token = "0x401AC7D")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 m_TextureOffset;

	[Token(Token = "0x401AC7E")]
	[FieldOffset(Offset = "0x20")]
	private MeshRenderer NHAHGEDAJHG;

	[Token(Token = "0x401AC7F")]
	[FieldOffset(Offset = "0x24")]
	private Material LJOAMLMCDGG;

	[Token(Token = "0x401AC80")]
	[FieldOffset(Offset = "0x28")]
	private Material IJEJNDBHFMP;

	[Token(Token = "0x401AC81")]
	[FieldOffset(Offset = "0x2C")]
	private Material EADFOPEEGDM;

	[Token(Token = "0x17001C3B")]
	private MeshRenderer LMDOGEMNNAC
	{
		[Token(Token = "0x6019DC8")]
		[Address(RVA = "0x25C5BAC", Offset = "0x25C5BAC", VA = "0x25C5BAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C3C")]
	public Material HGEHIJPGLCA
	{
		[Token(Token = "0x6019DC9")]
		[Address(RVA = "0x25C52AC", Offset = "0x25C52AC", VA = "0x25C52AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019DCA")]
		[Address(RVA = "0x25C5CA4", Offset = "0x25C5CA4", VA = "0x25C5CA4")]
		private set
		{
		}
	}

	[Token(Token = "0x6019DC7")]
	[Address(RVA = "0x25C5B14", Offset = "0x25C5B14", VA = "0x25C5B14")]
	public MipmapStreamingObj()
	{
	}

	[Token(Token = "0x6019DCB")]
	[Address(RVA = "0x25C4AAC", Offset = "0x25C4AAC", VA = "0x25C4AAC")]
	public void GenOriMatInst()
	{
	}

	[Token(Token = "0x6019DCC")]
	[Address(RVA = "0x25C504C", Offset = "0x25C504C", VA = "0x25C504C")]
	public void GenPreviewBlendMatInst(Material LDKDGIODEDD)
	{
	}

	[Token(Token = "0x6019DCD")]
	[Address(RVA = "0x25C52DC", Offset = "0x25C52DC", VA = "0x25C52DC")]
	public void SetOriMatInst()
	{
	}

	[Token(Token = "0x6019DCE")]
	[Address(RVA = "0x25C4E28", Offset = "0x25C4E28", VA = "0x25C4E28")]
	public void SetMaterial(Material HMNKPBLBCOC)
	{
	}

	[Token(Token = "0x6019DCF")]
	[Address(RVA = "0x25C50E4", Offset = "0x25C50E4", VA = "0x25C50E4")]
	public void SetPreviewBlendMatInst()
	{
	}

	[Token(Token = "0x6019DD0")]
	[Address(RVA = "0x25C5CDC", Offset = "0x25C5CDC", VA = "0x25C5CDC")]
	public void DestroyMatInsts()
	{
	}

	[Token(Token = "0x6019DD1")]
	[Address(RVA = "0x25C5954", Offset = "0x25C5954", VA = "0x25C5954")]
	public void DestroyOriTextures()
	{
	}

	[Token(Token = "0x6019DD2")]
	[Address(RVA = "0x25C47A8", Offset = "0x25C47A8", VA = "0x25C47A8")]
	public void SetCurMipmapLvl(int ENADCMAOCMD)
	{
	}

	[Token(Token = "0x6019DD3")]
	[Address(RVA = "0x25C5E48", Offset = "0x25C5E48", VA = "0x25C5E48")]
	private void IEDKEDHEKBE(string AOBALOEMGMJ, Texture2D KANJOBFCAIN)
	{
	}

	[Token(Token = "0x6019DD4")]
	[Address(RVA = "0x25C6134", Offset = "0x25C6134", VA = "0x25C6134")]
	public void Refresh(TextureInfo EMJGJCNJNJO)
	{
	}

	[Token(Token = "0x6019DD5")]
	[Address(RVA = "0x25C62C4", Offset = "0x25C62C4", VA = "0x25C62C4")]
	private void OnDestroy()
	{
	}
}
