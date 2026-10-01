# Ironwall Third-party Message Sender

관제 메시지를 외부 시스템에 UDP로 전달하는 .NET Framework 모듈입니다. 메시지 모델과 전송 대상 설정, WPF 설정 화면을 나누어 구성합니다.

## 구성

- [Models](Models): 전송 메시지와 목적지 설정
- [Services/MsgSendService.cs](Services/MsgSendService.cs): UTF-8 인코딩과 비동기 UDP 송신
- [ViewModels](ViewModels), [Views](Views): 설정 화면

## 사용 조건

Windows / .NET Framework 4.8, Caliburn.Micro와 관련 Ironwall 참조가 필요합니다. 이 모듈은 독립 서버가 아니라 상위 앱에서 호출하는 라이브러리입니다. 수신측의 메시지 형식과 대상 주소·포트를 맞춰야 합니다.

`SendMessage`의 성공 반환은 송신 호출의 성공을 뜻하며, 수신측 수신·저장을 확인하는 ACK는 아닙니다. 기존 Ironwall 연동 코드의 출처를 유지합니다.
