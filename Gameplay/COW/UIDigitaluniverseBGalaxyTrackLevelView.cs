using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001ECB")]
public class UIDigitaluniverseBGalaxyTrackLevelView : MonoBehaviour
{
	[Token(Token = "0x400C1EB")]
	[FieldOffset(Offset = "0xC")]
	private int TRACKNUM;

	[Token(Token = "0x400C1EC")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_TrackView0;

	[Token(Token = "0x400C1ED")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_TrackView1;

	[Token(Token = "0x400C1EE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_TrackView2;

	[Token(Token = "0x400C1EF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject m_TrackView3;

	[Token(Token = "0x400C1F0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_TrackView4;

	[Token(Token = "0x400C1F1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject m_TrackView5;

	[Token(Token = "0x400C1F2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_TrackView6;

	[Token(Token = "0x400C1F3")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject m_TrackView7;

	[Token(Token = "0x400C1F4")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_ListTracks;

	[Token(Token = "0x60095C8")]
	[Address(RVA = "0x2F64924", Offset = "0x2F64924", VA = "0x2F64924")]
	public UIDigitaluniverseBGalaxyTrackLevelView()
	{
	}

	[Token(Token = "0x60095C9")]
	[Address(RVA = "0x2F649F8", Offset = "0x2F649F8", VA = "0x2F649F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60095CA")]
	[Address(RVA = "0x2F64E6C", Offset = "0x2F64E6C", VA = "0x2F64E6C")]
	public GameObject GetTrackView(int trackIndex)
	{
		return null;
	}
}
