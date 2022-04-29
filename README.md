# Single Agent
------------------------------------------

#### How to install
- Open the installation file.
- Once the installation wizard has opened, click on `install`.
- Then User Access Control dialog box will appear, click on `YES` to proceed.
- Wazuh installation wizard will popup, continue installtation of Wazuh.
- Once the Wazuh installation proccess has been completed, check the `Run Agent configuration interface` and click on `Finish` button.
- Now, Wazuh Agent manager will open up. There you'll have to input Manage IP and provide Authentication key then click on `save`. Go to `Manage tab` and click on `restart` to restart the Wazuh Agent Service.
- Close Wazuh Agent manager wizard and DeceptiveBytes wizard will appear.
- Continue will installation and input Server Address and API key.
- Click on `next` and installation proccess will start.
- Once finished, Single Agent 3.0 setup will appear.
- Continue installation process.
- Once finished, locate Single Agent icon in System Tray and click on it to open.
#### How it works?

- Single agent checks different tools (Wazuh, Deceptive Bytes, Microsoft Defender, Microsoft Sysmon and Lateral Moment Protection) status such like whether it is Active, Connecting and Disconnected which will notify current status of agents with notification.
- If tools services are active it will notify that services are running else  it will display service has been stopped and turn status dot as green.
- When you restart the service, will give notification saying that services has been started and the red dot will turn green.
- Agent shows status by monitoring tools' services.

#### Features
- Status icon turns Red, Green, Gray and Yellow depending on its status.
- System tray icon will turn green if all the services are running properly, if not then it will turn red.
- User will be prompted with notification depending on status of that specific tool.

#### System Requirements
| Component | README |
| ------ | ------ |
| .NET Framework 4.8 | Must be pre-installed in computer in order to run the Single agent |
| Operating system | Windows 10 and later [64 bit] |
| CPU | Core 4 CPU or more |
| Memory | 8 GB RAM [16GB Recommended] |
