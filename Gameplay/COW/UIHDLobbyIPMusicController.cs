using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002122")]
public class UIHDLobbyIPMusicController : MonoBehaviour
{
	[Token(Token = "0x400CF86")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_Root;

	[Token(Token = "0x400CF87")]
	[FieldOffset(Offset = "0x10")]
	public Transform MusicDiscTrans;

	[Token(Token = "0x400CF88")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PlayIconObj;

	[Token(Token = "0x400CF89")]
	[FieldOffset(Offset = "0x18")]
	public GameObject StopIconObj;

	[Token(Token = "0x400CF8A")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_IsInTeam;

	[Token(Token = "0x400CF8B")]
	[FieldOffset(Offset = "0x1D")]
	private bool m_IsMusicActive;

	[Token(Token = "0x17001002")]
	public bool IsMusicActive
	{
		[Token(Token = "0x600AD6F")]
		[Address(RVA = "0x202E418", Offset = "0x202E418", VA = "0x202E418")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AD70")]
		[Address(RVA = "0x202E470", Offset = "0x202E470", VA = "0x202E470")]
		set
		{
		}
	}

	[Token(Token = "0x600AD6E")]
	[Address(RVA = "0x202E410", Offset = "0x202E410", VA = "0x202E410")]
	public UIHDLobbyIPMusicController()
	{
	}

	[Token(Token = "0x600AD71")]
	[Address(RVA = "0x202E600", Offset = "0x202E600", VA = "0x202E600")]
	private void Awake()
	{
	}

	[Token(Token = "0x600AD72")]
	[Address(RVA = "0x202EA54", Offset = "0x202EA54", VA = "0x202EA54")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600AD73")]
	[Address(RVA = "0x202EDDC", Offset = "0x202EDDC", VA = "0x202EDDC")]
	private void Update()
	{
	}

	[Token(Token = "0x600AD74")]
	[Address(RVA = "0x202EF40", Offset = "0x202EF40", VA = "0x202EF40")]
	private void OnIPMusicDiscRotateActivated(object[] data)
	{
	}

	[Token(Token = "0x600AD75")]
	[Address(RVA = "0x202F02C", Offset = "0x202F02C", VA = "0x202F02C")]
	private void UpdateLobbyMusic()
	{
	}

	[Token(Token = "0x600AD76")]
	[Address(RVA = "0x202F64C", Offset = "0x202F64C", VA = "0x202F64C")]
	private void OnIPMusicContainerClick(object[] data)
	{
	}

	[Token(Token = "0x600AD77")]
	[Address(RVA = "0x202F740", Offset = "0x202F740", VA = "0x202F740")]
	private void ShowIPMusicContainer(object[] data)
	{
	}

	[Token(Token = "0x600AD78")]
	[Address(RVA = "0x202F87C", Offset = "0x202F87C", VA = "0x202F87C")]
	private void OnLobbyControllerVisibleChanged(object[] data)
	{
	}

	[Token(Token = "0x600AD79")]
	[Address(RVA = "0x202FA60", Offset = "0x202FA60", VA = "0x202FA60")]
	private void OnLobbyGroupEnter(object[] data)
	{
	}

	[Token(Token = "0x600AD7A")]
	[Address(RVA = "0x202FB70", Offset = "0x202FB70", VA = "0x202FB70")]
	private void OnGroupQuit(object[] data)
	{
	}
}
