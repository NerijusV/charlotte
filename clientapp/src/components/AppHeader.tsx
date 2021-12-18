import React from 'react';
import { AppBar, Button, Grid, IconButton, TextField, Toolbar, Tooltip } from '@mui/material';
import { Search, Refresh } from '@mui/icons-material';


export const AppHeader = () => {
    return <AppBar
        position="static"
        color="default"
        elevation={0}
        sx={{ borderBottom: '1px solid rgba(0, 0, 0, 0.12)' }}>
        <Toolbar>
            <Grid container spacing={2} alignItems="center">
                <Grid item>
                    <Search color="inherit" sx={{ display: 'block' }} />
                </Grid>
                <Grid item xs>
                    <TextField
                        fullWidth
                        placeholder="Search by email address, phone number, or user UID"
                        InputProps={{
                            disableUnderline: true,
                            sx: { fontSize: 'default' },
                        }}
                        variant="standard"
                    />
                </Grid>
                <Grid item>
                    <Button variant="contained" sx={{ mr: 1 }}>
                        Add user
                    </Button>
                    <Tooltip title="Reload">
                        <IconButton>
                            <Refresh color="inherit" sx={{ display: 'block' }} />
                        </IconButton>
                    </Tooltip>
                </Grid>
            </Grid>
        </Toolbar>
    </AppBar>
}