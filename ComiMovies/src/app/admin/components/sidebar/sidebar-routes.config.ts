export const ROUTES = [
    { path: '/dashboard', title: 'Dashboard', icon: 'dashboard', children: null },
    { path: 'profile', title: 'User Profile', icon: 'person', children: null },
    { path: 'table', title: 'Table List', icon: 'content_paste', children: null },
    { path: '#genre', id: 'genre', title: 'Genre management', icon: 'apps', children: [
        {path: 'genres/create', title: 'Create', icon: 'C'},
        {path: 'genres/list', title: 'List', icon: 'L'},
        {path: 'genres/wizard', title: 'Wizard', icon: 'W'},
      ]},
    { path: 'notification', title: 'Notification', icon: 'notifications', children: null },
    { path: 'alert', title: 'Sweet Alert', icon: 'warning', children: null },
    { path: 'settings', title: 'Settings', icon: 'settings', children: null },
];
