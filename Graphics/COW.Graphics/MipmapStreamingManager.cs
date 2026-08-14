using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F89")]
public class MipmapStreamingManager : MonoBehaviour
{
	[Token(Token = "0x2003F8A")]
	private enum PPCPHBKBGKI
	{
		[Token(Token = "0x401AC71")]
		Close,
		[Token(Token = "0x401AC72")]
		Lowest,
		[Token(Token = "0x401AC73")]
		Normal,
		[Token(Token = "0x401AC74")]
		Undefined
	}

	[Token(Token = "0x2003F8B")]
	private enum FCKDIPKLOCI
	{
		[Token(Token = "0x401AC76")]
		Init,
		[Token(Token = "0x401AC77")]
		Opaque,
		[Token(Token = "0x401AC78")]
		Blend,
		[Token(Token = "0x401AC79")]
		Resume,
		[Token(Token = "0x401AC7A")]
		Undefined
	}

	[Token(Token = "0x401AC6A")]
	[FieldOffset(Offset = "0xC")]
	private PPCPHBKBGKI IGLOOEEDNBG;

	[Token(Token = "0x401AC6B")]
	[FieldOffset(Offset = "0x10")]
	private FCKDIPKLOCI GEFEPBMKHGA;

	[Token(Token = "0x401AC6C")]
	[FieldOffset(Offset = "0x14")]
	public List<MipmapStreamingObj> m_Objects;

	[Token(Token = "0x401AC6D")]
	[FieldOffset(Offset = "0x18")]
	public Camera m_Camera;

	[Token(Token = "0x401AC6E")]
	[FieldOffset(Offset = "0x1C")]
	public List<float> m_DistanceLevels;

	[Token(Token = "0x401AC6F")]
	[FieldOffset(Offset = "0x20")]
	public List<MipmapStreamingObj.TextureInfo> m_TextureInfos;

	[Token(Token = "0x6019DBD")]
	[Address(RVA = "0x25C41F4", Offset = "0x25C41F4", VA = "0x25C41F4")]
	public MipmapStreamingManager()
	{
	}

	[Token(Token = "0x6019DBE")]
	[Address(RVA = "0x25C42F8", Offset = "0x25C42F8", VA = "0x25C42F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6019DBF")]
	[Address(RVA = "0x25C49B8", Offset = "0x25C49B8", VA = "0x25C49B8")]
	private void MGGCIJGIABB(Material HMNKPBLBCOC)
	{
	}

	[Token(Token = "0x6019DC0")]
	[Address(RVA = "0x25C4B50", Offset = "0x25C4B50", VA = "0x25C4B50")]
	private void EPHMOJLDGGJ(Material HMNKPBLBCOC)
	{
	}

	[Token(Token = "0x6019DC1")]
	[Address(RVA = "0x25C4D30", Offset = "0x25C4D30", VA = "0x25C4D30")]
	private void IFMPODFJEGK(Material HMNKPBLBCOC)
	{
	}

	[Token(Token = "0x6019DC2")]
	[Address(RVA = "0x25C4E2C", Offset = "0x25C4E2C", VA = "0x25C4E2C")]
	private void BDADHAMIEEA(Material HMNKPBLBCOC)
	{
	}

	[Token(Token = "0x6019DC3")]
	[Address(RVA = "0x25C4C3C", Offset = "0x25C4C3C", VA = "0x25C4C3C")]
	private void GFEKKELIGDB(Material HMNKPBLBCOC)
	{
	}

	[Token(Token = "0x6019DC4")]
	[Address(RVA = "0x25C54A4", Offset = "0x25C54A4", VA = "0x25C54A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019DC5")]
	[Address(RVA = "0x25C5548", Offset = "0x25C5548", VA = "0x25C5548")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019DC6")]
	[Address(RVA = "0x25C4450", Offset = "0x25C4450", VA = "0x25C4450")]
	private int EILFLDBCNMD(MipmapStreamingObj ECINOMEHBKA)
	{
		return default(int);
	}
}
