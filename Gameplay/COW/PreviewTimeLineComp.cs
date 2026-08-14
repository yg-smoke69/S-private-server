using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace COW;

[Token(Token = "0x2000A45")]
public class PreviewTimeLineComp : MonoBehaviour
{
	[Token(Token = "0x4005B89")]
	[FieldOffset(Offset = "0xC")]
	public PlayableDirector PreviewDirector;

	[Token(Token = "0x4005B8A")]
	[FieldOffset(Offset = "0x10")]
	public float SkipToTarTime;

	[Token(Token = "0x6004FE2")]
	[Address(RVA = "0x1962FE4", Offset = "0x1962FE4", VA = "0x1962FE4")]
	public PreviewTimeLineComp()
	{
	}

	[Token(Token = "0x6004FE3")]
	[Address(RVA = "0x1962FF8", Offset = "0x1962FF8", VA = "0x1962FF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004FE4")]
	[Address(RVA = "0x19631A4", Offset = "0x19631A4", VA = "0x19631A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004FE5")]
	[Address(RVA = "0x195FBA0", Offset = "0x195FBA0", VA = "0x195FBA0")]
	public void PlayTimeLine(bool isfirst = true)
	{
	}

	[Token(Token = "0x6004FE6")]
	[Address(RVA = "0x195F424", Offset = "0x195F424", VA = "0x195F424")]
	public void PlayByTime(float time)
	{
	}

	[Token(Token = "0x6004FE7")]
	[Address(RVA = "0x19632CC", Offset = "0x19632CC", VA = "0x19632CC")]
	private void OnTimeLineSkipped(object[] data)
	{
	}
}
