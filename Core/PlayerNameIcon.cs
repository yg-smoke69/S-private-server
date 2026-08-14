using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000741")]
public class PlayerNameIcon : MonoBehaviour
{
	[Token(Token = "0x4004CCE")]
	[FieldOffset(Offset = "0xC")]
	public Transform ShowRoot;

	[Token(Token = "0x4004CCF")]
	[FieldOffset(Offset = "0x10")]
	public GameObject NumberMesh;

	[Token(Token = "0x4004CD0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_IsWolf;

	[Token(Token = "0x4004CD1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_IsHuman;

	[Token(Token = "0x4004CD2")]
	[FieldOffset(Offset = "0x1C")]
	public List<Texture> NumberTextureConfigs;

	[Token(Token = "0x6002DD6")]
	[Address(RVA = "0x1E22688", Offset = "0x1E22688", VA = "0x1E22688")]
	public PlayerNameIcon()
	{
	}

	[Token(Token = "0x6002DD7")]
	[Address(RVA = "0x1E22714", Offset = "0x1E22714", VA = "0x1E22714")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DD8")]
	[Address(RVA = "0x1E2276C", Offset = "0x1E2276C", VA = "0x1E2276C")]
	public void ChangeToWolf()
	{
	}

	[Token(Token = "0x6002DD9")]
	[Address(RVA = "0x1E2279C", Offset = "0x1E2279C", VA = "0x1E2279C")]
	public void ChangeNumber(int showNumber)
	{
	}

	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x1E228A0", Offset = "0x1E228A0", VA = "0x1E228A0")]
	public void ChangeToDead()
	{
	}

	[Token(Token = "0x6002DDB")]
	[Address(RVA = "0x1E228A4", Offset = "0x1E228A4", VA = "0x1E228A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002DDC")]
	[Address(RVA = "0x1E22A00", Offset = "0x1E22A00", VA = "0x1E22A00")]
	public void PredictRole(bool isWolf)
	{
	}
}
