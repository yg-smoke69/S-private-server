using COW.GamePlay;
using COW.Graphics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022A6")]
public class PlayerLagHint : MonoBehaviour
{
	[Token(Token = "0x400D8D5")]
	[FieldOffset(Offset = "0xC")]
	public GameObject HintObj;

	[Token(Token = "0x400D8D6")]
	[FieldOffset(Offset = "0x10")]
	public MultiBillboard MultiBillboard;

	[Token(Token = "0x400D8D7")]
	[FieldOffset(Offset = "0x14")]
	public float MaxScale;

	[Token(Token = "0x400D8D8")]
	[FieldOffset(Offset = "0x18")]
	public float KeepScaleDistance;

	[Token(Token = "0x400D8D9")]
	[FieldOffset(Offset = "0x1C")]
	public float MaxScaleDistance;

	[Token(Token = "0x400D8DA")]
	[FieldOffset(Offset = "0x20")]
	public float MaxShowDistance;

	[Token(Token = "0x400D8DB")]
	[FieldOffset(Offset = "0x24")]
	public float Radius;

	[Token(Token = "0x400D8DC")]
	[FieldOffset(Offset = "0x28")]
	private Player m_BindPlayer;

	[Token(Token = "0x400D8DD")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_ShowEffect;

	[Token(Token = "0x400D8DE")]
	[FieldOffset(Offset = "0x30")]
	private float m_ShowEffectTime;

	[Token(Token = "0x400D8DF")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_HintCacheScale;

	[Token(Token = "0x400D8E0")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_Target;

	[Token(Token = "0x400D8E1")]
	[FieldOffset(Offset = "0x44")]
	private bool m_KeepEffectWaitLagStateChange;

	[Token(Token = "0x400D8E2")]
	[FieldOffset(Offset = "0x48")]
	private BitArrayBoolean m_HintObjIsVisible;

	[Token(Token = "0x400D8E3")]
	private const uint ISVISIBLE_BINDPLAYERVISIBLE = 1u;

	[Token(Token = "0x400D8E4")]
	private const uint ISVISIBLE_BINDPLAYERISLAG = 2u;

	[Token(Token = "0x600BE83")]
	[Address(RVA = "0x1C08F88", Offset = "0x1C08F88", VA = "0x1C08F88")]
	public PlayerLagHint()
	{
	}

	[Token(Token = "0x600BE84")]
	[Address(RVA = "0x1C0908C", Offset = "0x1C0908C", VA = "0x1C0908C")]
	private void Start()
	{
	}

	[Token(Token = "0x600BE85")]
	[Address(RVA = "0x1C09230", Offset = "0x1C09230", VA = "0x1C09230")]
	public void BindPlayer(IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x600BE86")]
	[Address(RVA = "0x1C09620", Offset = "0x1C09620", VA = "0x1C09620")]
	public void BindPlayerVisibleChange(bool visible)
	{
	}

	[Token(Token = "0x600BE87")]
	[Address(RVA = "0x1C096B0", Offset = "0x1C096B0", VA = "0x1C096B0")]
	public void PlayerLagStateChange(bool isLag)
	{
	}

	[Token(Token = "0x600BE88")]
	[Address(RVA = "0x1C097DC", Offset = "0x1C097DC", VA = "0x1C097DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600BE89")]
	[Address(RVA = "0x1C09560", Offset = "0x1C09560", VA = "0x1C09560")]
	private void RefreshHintObjVisible()
	{
	}

	[Token(Token = "0x600BE8A")]
	[Address(RVA = "0x1C099DC", Offset = "0x1C099DC", VA = "0x1C099DC")]
	private void BetweenTwoTarget()
	{
	}

	[Token(Token = "0x600BE8B")]
	[Address(RVA = "0x1C09C94", Offset = "0x1C09C94", VA = "0x1C09C94")]
	private void KeepScale()
	{
	}
}
