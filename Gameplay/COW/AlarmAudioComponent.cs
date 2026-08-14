using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20003EF")]
public class AlarmAudioComponent : MonoBehaviour
{
	[Token(Token = "0x40039C0")]
	[FieldOffset(Offset = "0xC")]
	public float m_StartAlarmSecound;

	[Token(Token = "0x40039C1")]
	[FieldOffset(Offset = "0x10")]
	public float m_EndAlarmSecound;

	[Token(Token = "0x40039C2")]
	[FieldOffset(Offset = "0x14")]
	private AudioSource m_AlarmAudioSource;

	[Token(Token = "0x40039C3")]
	[FieldOffset(Offset = "0x18")]
	private SafeZone m_SafeZone;

	[Token(Token = "0x40039C4")]
	[FieldOffset(Offset = "0x1C")]
	private AudioClip m_NormalAlarmSound;

	[Token(Token = "0x40039C5")]
	[FieldOffset(Offset = "0x20")]
	private AudioClip m_SpecialAlarmSound;

	[Token(Token = "0x40039C6")]
	[FieldOffset(Offset = "0x24")]
	private bool m_IsPlayingAlarm;

	[Token(Token = "0x40039C7")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_CurPlayingObject;

	[Token(Token = "0x600127B")]
	[Address(RVA = "0x14C43DC", Offset = "0x14C43DC", VA = "0x14C43DC")]
	public AlarmAudioComponent()
	{
	}

	[Token(Token = "0x600127C")]
	[Address(RVA = "0x14C43FC", Offset = "0x14C43FC", VA = "0x14C43FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600127D")]
	[Address(RVA = "0x14C48B8", Offset = "0x14C48B8", VA = "0x14C48B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600127E")]
	[Address(RVA = "0x14C4D4C", Offset = "0x14C4D4C", VA = "0x14C4D4C")]
	private void StopAlam()
	{
	}

	[Token(Token = "0x600127F")]
	[Address(RVA = "0x14C4F2C", Offset = "0x14C4F2C", VA = "0x14C4F2C")]
	private void StartAlarm()
	{
	}

	[Token(Token = "0x6001280")]
	[Address(RVA = "0x14C4A24", Offset = "0x14C4A24", VA = "0x14C4A24")]
	private void UpdateAlarm()
	{
	}
}
