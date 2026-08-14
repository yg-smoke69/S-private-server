using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x2003E35")]
public class AkRTPCTrack : TrackAsset
{
	[Token(Token = "0x401A569")]
	[FieldOffset(Offset = "0x48")]
	public RTPC Parameter;

	[Token(Token = "0x60194A8")]
	[Address(RVA = "0x36C4030", Offset = "0x36C4030", VA = "0x36C4030")]
	public AkRTPCTrack()
	{
	}

	[Token(Token = "0x60194A9")]
	[Address(RVA = "0x36C40B4", Offset = "0x36C40B4", VA = "0x36C40B4", Slot = "14")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Playable);
	}

	[Token(Token = "0x60194AA")]
	[Address(RVA = "0x36C419C", Offset = "0x36C419C", VA = "0x36C419C")]
	public void setPlayableProperties()
	{
	}

	[Token(Token = "0x60194AB")]
	[Address(RVA = "0x36C4584", Offset = "0x36C4584", VA = "0x36C4584")]
	public void OnValidate()
	{
	}
}
