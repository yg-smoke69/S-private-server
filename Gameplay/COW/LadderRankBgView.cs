using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A8E")]
public class LadderRankBgView : MonoBehaviour
{
	[Token(Token = "0x4018E78")]
	[FieldOffset(Offset = "0xC")]
	public GameObject bronzeEffect;

	[Token(Token = "0x4018E79")]
	[FieldOffset(Offset = "0x10")]
	public GameObject sliverEffect;

	[Token(Token = "0x4018E7A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goldEffect;

	[Token(Token = "0x4018E7B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject platinumEffect;

	[Token(Token = "0x4018E7C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject diamondEffect;

	[Token(Token = "0x4018E7D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject kingEffect;

	[Token(Token = "0x4018E7E")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_ParticleObject;

	[Token(Token = "0x601734E")]
	[Address(RVA = "0x1EF6CA8", Offset = "0x1EF6CA8", VA = "0x1EF6CA8")]
	public LadderRankBgView()
	{
	}

	[Token(Token = "0x601734F")]
	[Address(RVA = "0x1EF6CB0", Offset = "0x1EF6CB0", VA = "0x1EF6CB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6017350")]
	[Address(RVA = "0x1EF6F20", Offset = "0x1EF6F20", VA = "0x1EF6F20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6017351")]
	[Address(RVA = "0x1EF6E20", Offset = "0x1EF6E20", VA = "0x1EF6E20")]
	private void Refresh(int _currentRank)
	{
	}

	[Token(Token = "0x6017352")]
	[Address(RVA = "0x1EF6F7C", Offset = "0x1EF6F7C", VA = "0x1EF6F7C")]
	private void GenerateEffect(GameObject _obj)
	{
	}
}
