 GITHUB
                    │
                    │ Actions
                    ▼
        ┌─────────────────────────┐
        │       SERVIDOR          │
        │                         │
        │                         │
        │  GitHub Actions Runner  │
        │           │             │
        │           ▼             │
        │       .NET 8            │
        │           │             │
        │     ┌─────┴─────┐       │
        │     ▼           ▼       │
        │   TEST         PROD     │
        │   :5001        :5002    │
        │     │           │       │
        │     ▼           ▼       │
        │  releases/   releases/ │
        │     │           │       │
        │   current     current   │
        │     │           │       │
        │     ▼           ▼       │
        │  systemd     systemd   │
